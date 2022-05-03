namespace Shared.DataAccess.Entities
{
    public abstract class EntityBase
    {
        public long Id { get; protected set; }

        protected EntityBase()
        {
        }
        protected EntityBase(long id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not EntityBase other)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetUnproxiedType(this) != GetUnproxiedType(other))
                return false;

            if (Id.Equals(default) || other.Id.Equals(default))
                return false;

            return Id.Equals(other.Id);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetUnproxiedType(this).ToString() + Id).GetHashCode();
        }

        internal static Type GetUnproxiedType(object obj)
        {
            const string efCoreProxyPrefix = "Castle.Proxies.";
            const string nHibernateProxyPrefix = "Proxy";

            Type type = obj.GetType();
            string typeString = type.ToString();

            if (typeString.Contains(efCoreProxyPrefix) || typeString.Contains(nHibernateProxyPrefix))
                return type.BaseType;

            return type;
        }
    }
}