using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    // class fields: class_fields
    // normal variables: normalVariables
    // classes: Classes
    // functions: Functions(...)
    public abstract class BaseEntity
    {
        private int idx;

        public int Idx { get => idx; set => idx = value; }
    }
}
