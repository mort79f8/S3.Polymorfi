using System;
using System.Collections.Generic;
using System.Text;

namespace S3.Polymorfi.Entities
{
    public abstract class Entity : IPersistable
    {
        #region Fields
        private int id;
        #endregion

        #region Constructors
        public Entity(int id)
        {
            Id = id;
        }

        public Entity()
        {

        }
        #endregion

        #region Properties
        public int Id { get; }
        #endregion
    }
}
