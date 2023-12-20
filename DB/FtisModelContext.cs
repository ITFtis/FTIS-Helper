using FtisHelperV2.DB.Model;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace FtisHelperV2.DB
{
    public class FtisModelContext : DbContext
    {
        public new static FtisModelContext Create(bool printLog = false)
        {
            var cxt = new FtisModelContext();
            if (printLog) cxt.Database.Log = (log) => Debug.WriteLine(log);
            return cxt;
        }

        // 您的內容已設定為使用應用程式組態檔 (App.config 或 Web.config)
        // 中的 'FtisModelContext' 連接字串。根據預設，這個連接字串的目標是
        // 您的 LocalDb 執行個體上的 'FtisHelperV2.DB.FtisModelContext' 資料庫。
        // 
        // 如果您的目標是其他資料庫和 (或) 提供者，請修改
        // 應用程式組態檔中的 'FtisModelContext' 連接字串。
        public FtisModelContext()
            : base(serverconn)
        {
            Database.SetInitializer<FtisModelContext>(null);
        }

        public static bool LocalTest
        {
            set
            {
                serverconn = value ? localconn : conn;
                Console.Write(serverconn);
            }
        }
        static string conn = "data source=120.100.102.109;initial catalog=FTIS-T8;persist security info=True;user id=pgtest;password=Ftis12341234;MultipleActiveResultSets=True;App=EntityFramework";
        static string localconn = "name=FtisModelContext";
        static string serverconn = conn; //預設正式

        // 針對您要包含在模型中的每種實體類型新增 DbSet。如需有關設定和使用
        // Code First 模型的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=390109。

        public virtual DbSet<F22cmmDep> F22cmmDep { get; set; }
        public virtual DbSet<F22cmmEmpDa1> F22cmmEmpDa1 { get; set; }
        public virtual DbSet<F22cmmEmpDa4> F22cmmEmpDa4 { get; set; }
        public virtual DbSet<F22cmmEmpDa5> F22cmmEmpDa5 { get; set; }
        public virtual DbSet<F22cmmEmpDa6> F22cmmEmpDa6 { get; set; }
        public virtual DbSet<F22cmmEmpDa6a> F22cmmEmpDa6a { get; set; }
        public virtual DbSet<F22cmmEmpDa7> F22cmmEmpDa7 { get; set; }
        public virtual DbSet<F22cmmEmpDa8> F22cmmEmpDa8 { get; set; }
        public virtual DbSet<F22cmmEmpDa9> F22cmmEmpDa9 { get; set; }
        public virtual DbSet<F22cmmEmpData> F22cmmEmpData { get; set; }
        public virtual DbSet<F22cmmEmpDataLog> F22cmmEmpDataLog { get; set; }
        public virtual DbSet<F22cmmGrade> F22cmmGrade { get; set; }
        public virtual DbSet<F22cmmProjectData> F22cmmProjectData { get; set; }
        public virtual DbSet<F22cmmProjectDataMap> F22cmmProjectDataMap { get; set; }
        public virtual DbSet<F22cmmTitle> F22cmmTitle { get; set; }
        public virtual DbSet<F22cmmCounty> F22cmmCounty { get; set; }
        public virtual DbSet<F22cmmMP> F22cmmMP { get; set; }
        public virtual DbSet<F22cmmSeat> F22cmmSeat { get; set; }
        public virtual DbSet<F22cmmTown> F22cmmTown { get; set; }
        public virtual DbSet<F22EmpCheckTime> F22EmpCheckTime { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<F22cmmEmpData>().HasOptional(s=>s.Seat);
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}