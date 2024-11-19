using CD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.View
{
    interface IView
    {
        void SetDataToText(Object item);
        void GetDataFromText();
    }
}
