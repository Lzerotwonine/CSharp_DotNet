using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controller
{
    internal class BranchController : IController
    {
        private List<IModel> branches;
        private BankSystemDataContext db; // DataContext từ LINQ to SQL

        public List<IModel> Items => branches;

        public BranchController()
        {
            branches = new List<IModel>();
            db = new BankSystemDataContext(); // Khởi tạo DataContext
        }

        // Tạo tài khoản mới
        public bool Create(IModel model)
        {
            var branch = model as BranchModel;
            if (IsExist(branch.Id)) return false;

            var dbBranch = new Branch
            {
                Id = branch.Id,
                Name = branch.Name,
                HouseNo = branch.HouseNo,
                City = branch.City
            };

            db.Branches.InsertOnSubmit(dbBranch);
            db.SubmitChanges();

            branches.Add(branch);
            return true;
        }

        // Cập nhật tài khoản
        public bool Update(IModel model)
        {
            var branch = model as BranchModel;
            var dbBranch = db.Branches.FirstOrDefault(a => a.Id == branch.Id);
            if (dbBranch == null) return false;

            dbBranch.Name = branch.Name;
            dbBranch.HouseNo = branch.HouseNo;
            dbBranch.City = branch.City;

            db.SubmitChanges();

            var existingBranch = Read(branch.Id) as BranchModel;
            existingBranch.Name = branch.Name;
            existingBranch.HouseNo = branch.HouseNo;
            existingBranch.City = branch.City;

            return true;
        }

        // Xóa tài khoản
        public bool Delete(object id)
        {
            var dbBranch = db.Branches.FirstOrDefault(a => a.Id == (string)id);
            if (dbBranch == null) return false;

            db.Branches.DeleteOnSubmit(dbBranch);
            db.SubmitChanges();

            var branch = Read(id) as BranchModel;
            if (branch != null)
            {
                branches.Remove(branch);
            }

            return true;
        }

        // Đọc tài khoản
        public IModel Read(object id)
        {
            return branches.FirstOrDefault(a => (a as BranchModel).Id == (string)id);
        }

        // Load tất cả tài khoản từ CSDL
        public bool Load()
        {
            var dbBranches = db.Branches.ToList();
            branches = dbBranches.Select(a => new BranchModel
            {
                Id = a.Id,
                Name = a.Name,
                HouseNo = a.HouseNo,
                City = a.City
            }).Cast<IModel>().ToList();

            return true;
        }

        // Phương thức Load tài khoản theo id
        public bool Load(object id)
        {
            var dbBranch = db.Branches.FirstOrDefault(a => a.Id == (string)id);
            if (dbBranch == null)
            {
                return false; // Không tìm thấy tài khoản với ID này
            }

            var branchModel = new BranchModel
            {
                Id = dbBranch.Id,
                Name = dbBranch.Name,
                HouseNo = dbBranch.HouseNo,
                City = dbBranch.City
            };

            branches.Clear();
            branches.Add(branchModel);

            return true;
        }

        // Kiểm tra tồn tại tài khoản theo ID
        public bool IsExist(object id)
        {
            return branches.Any(a => (a as BranchModel).Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var branch = model as BranchModel;
            return IsExist(branch.Id);
        }
    }
}
