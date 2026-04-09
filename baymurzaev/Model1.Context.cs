namespace baymurzaev
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class baymurzaevEntities : DbContext
    {
        private static baymurzaevEntities _context;

        public baymurzaevEntities()
            : base("name=baymurzaevEntities")
        {
        }

        public static baymurzaevEntities GetContext()
        {
            if (_context == null)
                _context = new baymurzaevEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Маршруты> Маршруты { get; set; }
        public virtual DbSet<Рейсы> Рейсы { get; set; }
        public virtual DbSet<Транспорт> Транспорт { get; set; }
    }
}