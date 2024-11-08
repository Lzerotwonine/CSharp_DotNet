using CD_Management.Model;
using System.Collections.Generic;

namespace CD_Management.Controller
{
    internal interface IController
    {
        List<IModel> Items { get; }
        bool Create(IModel model);
        bool Update(IModel model);
        bool Delete(object id);
        IModel Read(object id);
        bool Load();
        bool Load(object id);
        bool IsExist(object id);
        bool IsExist(IModel model);
    }
}