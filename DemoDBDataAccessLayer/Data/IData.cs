using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Data
{
    public interface IData
    {
        List<T> SelectAll<T>();
    }
}
