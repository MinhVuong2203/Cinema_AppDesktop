using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class OperationBLL
    {
        private OperationDAL _operationDAL;
        public OperationBLL()
        {
            _operationDAL = new OperationDAL();
        }

        public List<Operation> GetAllOperation()
        {
            return _operationDAL.getAllOperation();
        }

        public bool SaveEmployeeOperations(Dictionary<Guid, HashSet<int>> snapshot)
          => _operationDAL.SaveEmployeeOperations(snapshot);

    }
}
