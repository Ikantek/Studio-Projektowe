using System.Reflection;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GymManager.Models
{
    public partial class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acl> Acls { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<PgStatStatement> PgStatStatements { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2")
                .HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Acl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.HasKey(e => e.Id).HasName("acl_pkey");

                entity.ToTable("acl");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.TableName)
                    .HasMaxLength(30)
                    .IsRequired()
                    .HasColumnName("table_name");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .IsRequired();

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.Action).HasColumnName("action");

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientCascade)
                    .HasConstraintName("acl_user_id_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acl_role_id_fkey");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("discounts");

                entity.Property(e => e.Id)
                    .HasColumnName("discount_id")
                    .HasDefaultValueSql("nextval('discount_id_seq'::regclass)");

                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(9)
                    .HasColumnName("discount_code");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(150)
                    .HasColumnName("discount_description");

                entity.Property(e => e.DiscountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("discount_name");

                entity.Property(e => e.DiscountValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("discount_value");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date");
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.ToTable("exercise");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExcerciseName).HasColumnName("excercise_name");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(6550)
                    .HasColumnName("description");

                entity.Property(e => e.Header)
                    .HasMaxLength(255)
                    .HasColumnName("header");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PgStatStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnType("oid")
                    .HasColumnName("dbid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnType("oid")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasDefaultValueSql("nextval('role_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_parent");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.AccessRow).HasColumnName("access_row");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.TableName)
                    .HasMaxLength(30)
                    .HasColumnName("table_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("nextval('user_id_seq'::regclass)");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.GymPass)
                    .HasColumnType("date")
                    .HasColumnName("gym_pass");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("surname");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_role_id");
            });

            modelBuilder.HasSequence("discount_id_seq");

            modelBuilder.HasSequence("role_id_seq");

            modelBuilder.HasSequence("user_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
