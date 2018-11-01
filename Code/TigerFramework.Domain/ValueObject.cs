using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigerFramework.Core.EqualityHelpers;

namespace TigerFramework.Domain
{
    public abstract class ValueObject
    {
        public override bool Equals(object obj)
        {
            return EqualsBuilder.ReflectionEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return HashCodeBuilder.ReflectionHashCode(this);
        }
    }
}
