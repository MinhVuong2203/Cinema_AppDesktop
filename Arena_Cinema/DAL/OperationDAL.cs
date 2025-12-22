using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class OperationDAL
    {
        private readonly CinemaDBContext _context;
        public OperationDAL()
        {
            _context = new CinemaDBContext();
        }

        public List<Operation> getAllOperation()
        {
            try
            {
                return _context.Operations.ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in getAllOperation: {ex.Message}");
                return new List<Operation>();   
            }
            
        }

        // Phục vụ cho lưu quyền cho nhân viên
        public bool SaveEmployeeOperations(Dictionary<Guid, HashSet<int>> snapshot)
        {
            if (snapshot == null) return false;

                try
                {
                    // lấy danh sách employeeId và operationId cần dùng
                    var empIds = snapshot.Keys.ToList();
                    var opIds = snapshot.Values.SelectMany(x => x).Distinct().ToList();

                    // load operations 1 lần
                    var opDict = _context.Operations
                        .Where(o => opIds.Contains(o.OperationId))
                        .ToList()
                        .ToDictionary(o => o.OperationId);

                    // load employees + operations 1 lần
                    var employees = _context.Employees
                        .Include(e => e.Operations)
                        .Where(e => empIds.Contains(e.EmployeeID))
                        .ToList();

                    // cập nhật quyền
                    foreach (var emp in employees)
                    {
                        emp.Operations.Clear();

                        if (snapshot.TryGetValue(emp.EmployeeID, out var desiredOps))
                        {
                            foreach (var opId in desiredOps)
                            {
                                if (opDict.TryGetValue(opId, out var opEntity))
                                    emp.Operations.Add(opEntity);
                            }
                        }
                    }

                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    
                    Debug.WriteLine("SaveEmployeeOperations error: " + ex.Message);
                    return false;
                }
        }
    }
}
