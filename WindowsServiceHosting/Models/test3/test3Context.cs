using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindowsServiceHosting.Models.test3
{
    public partial class test3Context : DbContext
    {
        public test3Context()
        {
        }

        public test3Context(DbContextOptions<test3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Aksesuar> Aksesuar { get; set; }
        public virtual DbSet<AksesuarDeger> AksesuarDeger { get; set; }
        public virtual DbSet<AksesuarGrubu> AksesuarGrubu { get; set; }
        public virtual DbSet<Analysis> Analysis { get; set; }
        public virtual DbSet<AuditDataItemPersistent> AuditDataItemPersistent { get; set; }
        public virtual DbSet<AuditedObjectWeakReference> AuditedObjectWeakReference { get; set; }
        public virtual DbSet<AydinlatmaMetni> AydinlatmaMetni { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BasicUser> BasicUser { get; set; }
        public virtual DbSet<Boyut> Boyut { get; set; }
        public virtual DbSet<CerezPolitikasi> CerezPolitikasi { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DashboardData> DashboardData { get; set; }
        public virtual DbSet<DegerTipleri> DegerTipleri { get; set; }
        public virtual DbSet<Degerler> Degerler { get; set; }
        public virtual DbSet<Departmanlar> Departmanlar { get; set; }
        public virtual DbSet<DigerDokumanlar> DigerDokumanlar { get; set; }
        public virtual DbSet<EmailListesi> EmailListesi { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<ExtendedSecurityRole> ExtendedSecurityRole { get; set; }
        public virtual DbSet<FileData> FileData { get; set; }
        public virtual DbSet<FiyatListesi> FiyatListesi { get; set; }
        public virtual DbSet<Fotograflar> Fotograflar { get; set; }
        public virtual DbSet<GizlilikPolitikasi> GizlilikPolitikasi { get; set; }
        public virtual DbSet<Haberler> Haberler { get; set; }
        public virtual DbSet<HakkimizdaAltGrup> HakkimizdaAltGrup { get; set; }
        public virtual DbSet<HakkimizdaVeAltBilgi> HakkimizdaVeAltBilgi { get; set; }
        public virtual DbSet<Hcategory> Hcategory { get; set; }
        public virtual DbSet<HeaderFooter> HeaderFooter { get; set; }
        public virtual DbSet<IdgeneratorTable> IdgeneratorTable { get; set; }
        public virtual DbSet<IkVizyonPolitika> IkVizyonPolitika { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<KaliteDokumanlari> KaliteDokumanlari { get; set; }
        public virtual DbSet<KapakOpsiyonDoc> KapakOpsiyonDoc { get; set; }
        public virtual DbSet<KapakOpsiyonlari> KapakOpsiyonlari { get; set; }
        public virtual DbSet<Kataloglar> Kataloglar { get; set; }
        public virtual DbSet<KataloglarSayfasi> KataloglarSayfasi { get; set; }
        public virtual DbSet<KlasorDokumanlari> KlasorDokumanlari { get; set; }
        public virtual DbSet<Klasorler> Klasorler { get; set; }
        public virtual DbSet<KpiDefinition> KpiDefinition { get; set; }
        public virtual DbSet<KpiHistoryItem> KpiHistoryItem { get; set; }
        public virtual DbSet<KpiInstance> KpiInstance { get; set; }
        public virtual DbSet<KpiScorecard> KpiScorecard { get; set; }
        public virtual DbSet<KpiScorecardScorecardsKpiInstanceIndicators> KpiScorecardScorecardsKpiInstanceIndicators { get; set; }
        public virtual DbSet<KurumsalLogoKullanimi> KurumsalLogoKullanimi { get; set; }
        public virtual DbSet<Logolar> Logolar { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MediaDataObject> MediaDataObject { get; set; }
        public virtual DbSet<ModelDifference> ModelDifference { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspect { get; set; }
        public virtual DbSet<MontajKlavuzlari> MontajKlavuzlari { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<OnayBekleyenDokumanlar> OnayBekleyenDokumanlar { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OtoKodTanim> OtoKodTanim { get; set; }
        public virtual DbSet<Ozellikler> Ozellikler { get; set; }
        public virtual DbSet<Parcalar> Parcalar { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyRole> PermissionPolicyRole { get; set; }
        public virtual DbSet<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObject { get; set; }
        public virtual DbSet<PermissionPolicyUser> PermissionPolicyUser { get; set; }
        public virtual DbSet<PermissionPolicyUserUsersPermissionPolicyRoleRoles> PermissionPolicyUserUsersPermissionPolicyRoleRoles { get; set; }
        public virtual DbSet<PersistentPermission> PersistentPermission { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumber { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<PropertyBag> PropertyBag { get; set; }
        public virtual DbSet<PropertyBagDescriptor> PropertyBagDescriptor { get; set; }
        public virtual DbSet<PropertyDescriptor> PropertyDescriptor { get; set; }
        public virtual DbSet<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags> PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<Reklamlar> Reklamlar { get; set; }
        public virtual DbSet<Renk> Renk { get; set; }
        public virtual DbSet<ReportData> ReportData { get; set; }
        public virtual DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceResourcesEventEvents> ResourceResourcesEventEvents { get; set; }
        public virtual DbSet<RevizeNedenleri> RevizeNedenleri { get; set; }
        public virtual DbSet<Revizeler> Revizeler { get; set; }
        public virtual DbSet<RichTextMailMergeData> RichTextMailMergeData { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleBase> RoleBase { get; set; }
        public virtual DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual DbSet<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles> SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles { get; set; }
        public virtual DbSet<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemUser> SecuritySystemUser { get; set; }
        public virtual DbSet<SecuritySystemUserUsersSecuritySystemRoleRoles> SecuritySystemUserUsersSecuritySystemRoleRoles { get; set; }
        public virtual DbSet<Sertifikalar> Sertifikalar { get; set; }
        public virtual DbSet<ServerPrefix> ServerPrefix { get; set; }
        public virtual DbSet<SimpleUser> SimpleUser { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Taglar> Taglar { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TeknikCizimler> TeknikCizimler { get; set; }
        public virtual DbSet<TeknikSartname> TeknikSartname { get; set; }
        public virtual DbSet<Update> Update { get; set; }
        public virtual DbSet<UretimDokumanlari> UretimDokumanlari { get; set; }
        public virtual DbSet<UrunAilesi> UrunAilesi { get; set; }
        public virtual DbSet<UrunDegerler> UrunDegerler { get; set; }
        public virtual DbSet<UrunGrubu> UrunGrubu { get; set; }
        public virtual DbSet<UrunSerisi> UrunSerisi { get; set; }
        public virtual DbSet<UrunTeknikSartname> UrunTeknikSartname { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunlerurunlerAksesuaraksesuar> UrunlerurunlerAksesuaraksesuar { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserMid2> UserMid2 { get; set; }
        public virtual DbSet<UserUsersRoleRoles> UserUsersRoleRoles { get; set; }
        public virtual DbSet<VideolarSayfasi> VideolarSayfasi { get; set; }
        public virtual DbSet<WebFotograf> WebFotograf { get; set; }
        public virtual DbSet<XpoInstanceKey> XpoInstanceKey { get; set; }
        public virtual DbSet<XpoRunningWorkflowInstanceInfo> XpoRunningWorkflowInstanceInfo { get; set; }
        public virtual DbSet<XpoStartWorkflowRequest> XpoStartWorkflowRequest { get; set; }
        public virtual DbSet<XpoState> XpoState { get; set; }
        public virtual DbSet<XpoStateAppearance> XpoStateAppearance { get; set; }
        public virtual DbSet<XpoStateMachine> XpoStateMachine { get; set; }
        public virtual DbSet<XpoTrackingRecord> XpoTrackingRecord { get; set; }
        public virtual DbSet<XpoTransition> XpoTransition { get; set; }
        public virtual DbSet<XpoUserActivityVersion> XpoUserActivityVersion { get; set; }
        public virtual DbSet<XpoWorkflowDefinition> XpoWorkflowDefinition { get; set; }
        public virtual DbSet<XpoWorkflowInstance> XpoWorkflowInstance { get; set; }
        public virtual DbSet<XpoWorkflowInstanceControlCommandRequest> XpoWorkflowInstanceControlCommandRequest { get; set; }
        public virtual DbSet<XpobjectType> XpobjectType { get; set; }
        public virtual DbSet<XpweakReference> XpweakReference { get; set; }
        public virtual DbSet<XtraReportData> XtraReportData { get; set; }
        public virtual DbSet<Yetkilendirme> Yetkilendirme { get; set; }
        public virtual DbSet<YonetimKadrosu> YonetimKadrosu { get; set; }
        public virtual DbSet<YoutubeVideo> YoutubeVideo { get; set; }
        public virtual DbSet<Yukseklik> Yukseklik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.26.0.30;Database=test3;User=sa;Password=Mdsf2020@;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Country)
                    .HasName("iCountry_Address");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Address");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.StateProvince).HasMaxLength(100);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.Property(e => e.ZipPostal).HasMaxLength(100);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Address_Country");
            });

            modelBuilder.Entity<Aksesuar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iAksesuarGrubu_Aksesuar");

                entity.HasIndex(e => e.Boyut)
                    .HasName("iboyut_Aksesuar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Aksesuar");

                entity.HasIndex(e => e.Yukseklik)
                    .HasName("iyukseklik_Aksesuar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AksesuarAdi).HasMaxLength(100);

                entity.Property(e => e.AksesuarAdi1)
                    .HasColumnName("_AksesuarAdi")
                    .HasMaxLength(100);

                entity.Property(e => e.AksesuarKodu).HasMaxLength(100);

                entity.Property(e => e.Boyut).HasColumnName("boyut");

                entity.Property(e => e.EngAksesuarAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.StokKodu).HasMaxLength(100);

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.Property(e => e.Yukseklik).HasColumnName("yukseklik");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_Aksesuar_AksesuarGrubu");

                entity.HasOne(d => d.BoyutNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.Boyut)
                    .HasConstraintName("FK_Aksesuar_boyut");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Aksesuar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Aksesuar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Aksesuar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Aksesuar_urunler");

                entity.HasOne(d => d.YukseklikNavigation)
                    .WithMany(p => p.Aksesuar)
                    .HasForeignKey(d => d.Yukseklik)
                    .HasConstraintName("FK_Aksesuar_yukseklik");
            });

            modelBuilder.Entity<AksesuarDeger>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("aksesuarDeger");

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_aksesuarDeger");

                entity.HasIndex(e => e.Degerler)
                    .HasName("idegerler_aksesuarDeger");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_aksesuarDeger");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.Deger).HasMaxLength(100);

                entity.Property(e => e.Degerler).HasColumnName("degerler");

                entity.Property(e => e.EngDeger).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.AksesuarDeger)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_aksesuarDeger_aksesuar");

                entity.HasOne(d => d.DegerlerNavigation)
                    .WithMany(p => p.AksesuarDeger)
                    .HasForeignKey(d => d.Degerler)
                    .HasConstraintName("FK_aksesuarDeger_degerler");
            });

            modelBuilder.Entity<AksesuarGrubu>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_AksesuarGrubu");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AksesuarGrupAdi).HasMaxLength(100);

                entity.Property(e => e.EngAksesuarGrupAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.WebUrl).HasMaxLength(100);
            });

            modelBuilder.Entity<Analysis>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Analysis");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AuditDataItemPersistent>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AuditedObject)
                    .HasName("iAuditedObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_AuditDataItemPersistent");

                entity.HasIndex(e => e.ModifiedOn)
                    .HasName("iModifiedOn_AuditDataItemPersistent");

                entity.HasIndex(e => e.NewObject)
                    .HasName("iNewObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.OldObject)
                    .HasName("iOldObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.OperationType)
                    .HasName("iOperationType_AuditDataItemPersistent");

                entity.HasIndex(e => e.UserName)
                    .HasName("iUserName_AuditDataItemPersistent");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasMaxLength(1024);

                entity.Property(e => e.OldValue).HasMaxLength(1024);

                entity.Property(e => e.OperationType).HasMaxLength(100);

                entity.Property(e => e.PropertyName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.AuditedObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistent)
                    .HasForeignKey(d => d.AuditedObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_AuditedObject");

                entity.HasOne(d => d.NewObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistentNewObjectNavigation)
                    .HasForeignKey(d => d.NewObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_NewObject");

                entity.HasOne(d => d.OldObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistentOldObjectNavigation)
                    .HasForeignKey(d => d.OldObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_OldObject");
            });

            modelBuilder.Entity<AuditedObjectWeakReference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.HasOne(d => d.O)
                    .WithOne(p => p.AuditedObjectWeakReference)
                    .HasForeignKey<AuditedObjectWeakReference>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditedObjectWeakReference_Oid");
            });

            modelBuilder.Entity<AydinlatmaMetni>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_AydinlatmaMetni");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AksesuarGrup)
                    .HasName("iAksesuarGrup_Banner");

                entity.HasIndex(e => e.AydinlatmaMetni)
                    .HasName("iAydinlatmaMetni_Banner");

                entity.HasIndex(e => e.CerezPolitikasi)
                    .HasName("iCerezPolitikasi_Banner");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Banner");

                entity.HasIndex(e => e.GizlilikPolitikasi)
                    .HasName("iGizlilikPolitikasi_Banner");

                entity.HasIndex(e => e.IkVizyonPolitika)
                    .HasName("iIK_VizyonPolitika_Banner");

                entity.HasIndex(e => e.UrunGrup)
                    .HasName("iUrunGrup_Banner");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iUrunSerisi_Banner");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.FotografEng).HasColumnName("fotografENG");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IkVizyonPolitika).HasColumnName("IK_VizyonPolitika");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AksesuarGrupNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.AksesuarGrup)
                    .HasConstraintName("FK_Banner_AksesuarGrup");

                entity.HasOne(d => d.AydinlatmaMetniNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.AydinlatmaMetni)
                    .HasConstraintName("FK_Banner_AydinlatmaMetni");

                entity.HasOne(d => d.CerezPolitikasiNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.CerezPolitikasi)
                    .HasConstraintName("FK_Banner_CerezPolitikasi");

                entity.HasOne(d => d.GizlilikPolitikasiNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.GizlilikPolitikasi)
                    .HasConstraintName("FK_Banner_GizlilikPolitikasi");

                entity.HasOne(d => d.IkVizyonPolitikaNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.IkVizyonPolitika)
                    .HasConstraintName("FK_Banner_IK_VizyonPolitika");

                entity.HasOne(d => d.UrunGrupNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.UrunGrup)
                    .HasConstraintName("FK_Banner_UrunGrup");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Banner)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Banner_UrunSerisi");
            });

            modelBuilder.Entity<BasicUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_BasicUser");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Boyut>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Boyut");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Derinlik).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Genislik).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<CerezPolitikasi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_CerezPolitikasi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Country");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneCode).HasMaxLength(100);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Currency");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Currencies).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<DashboardData>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_DashboardData");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<DegerTipleri>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_DegerTipleri");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DegerTipi).HasMaxLength(100);

                entity.Property(e => e.EngDegerTipi).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Degerler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.DegerTipi)
                    .HasName("iDegerTipi_Degerler");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Degerler");

                entity.HasIndex(e => e.Ozellikler)
                    .HasName("iozellikler_Degerler");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Degerler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Deger).HasMaxLength(100);

                entity.Property(e => e.DegerAdi).HasMaxLength(100);

                entity.Property(e => e.EngDegerAdi).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Ozellikler).HasColumnName("ozellikler");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.DegerTipiNavigation)
                    .WithMany(p => p.Degerler)
                    .HasForeignKey(d => d.DegerTipi)
                    .HasConstraintName("FK_Degerler_DegerTipi");

                entity.HasOne(d => d.OzelliklerNavigation)
                    .WithMany(p => p.Degerler)
                    .HasForeignKey(d => d.Ozellikler)
                    .HasConstraintName("FK_Degerler_ozellikler");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Degerler)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Degerler_urunler");
            });

            modelBuilder.Entity<Departmanlar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.DepartmanMuduru)
                    .HasName("iDepartmanMuduru_Departmanlar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Departmanlar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DepartmanAdi).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.DepartmanMuduruNavigation)
                    .WithMany(p => p.DepartmanlarNavigation)
                    .HasForeignKey(d => d.DepartmanMuduru)
                    .HasConstraintName("FK_Departmanlar_DepartmanMuduru");
            });

            modelBuilder.Entity<DigerDokumanlar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_DigerDokumanlar");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_DigerDokumanlar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_DigerDokumanlar");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_DigerDokumanlar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_DigerDokumanlar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_DigerDokumanlar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_DigerDokumanlar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_DigerDokumanlar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_DigerDokumanlar_aksesuar");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_DigerDokumanlar_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_DigerDokumanlar_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_DigerDokumanlar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_DigerDokumanlar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_DigerDokumanlar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.DigerDokumanlar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_DigerDokumanlar_urunler");
            });

            modelBuilder.Entity<EmailListesi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EmailListesi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.EndOn)
                    .HasName("iEndOn_Event");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Event");

                entity.HasIndex(e => e.RecurrencePattern)
                    .HasName("iRecurrencePattern_Event");

                entity.HasIndex(e => e.StartOn)
                    .HasName("iStartOn_Event");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AlarmTime).HasColumnType("datetime");

                entity.Property(e => e.EndOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.ReminderInfoXml).HasMaxLength(200);

                entity.Property(e => e.StartOn).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.HasOne(d => d.RecurrencePatternNavigation)
                    .WithMany(p => p.InverseRecurrencePatternNavigation)
                    .HasForeignKey(d => d.RecurrencePattern)
                    .HasConstraintName("FK_Event_RecurrencePattern");
            });

            modelBuilder.Entity<ExtendedSecurityRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.O)
                    .WithOne(p => p.ExtendedSecurityRole)
                    .HasForeignKey<ExtendedSecurityRole>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExtendedSecurityRole_Oid");
            });

            modelBuilder.Entity<FileData>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_FileData");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<FiyatListesi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_FiyatListesi");

                entity.HasIndex(e => e.Currency)
                    .HasName("iCurrency_FiyatListesi");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_FiyatListesi");

                entity.HasIndex(e => e.FileData)
                    .HasName("ifileData_FiyatListesi");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_FiyatListesi");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_FiyatListesi");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_FiyatListesi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.FileData).HasColumnName("fileData");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.FiyatListesi)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_FiyatListesi_aksesuar");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.FiyatListesi)
                    .HasForeignKey(d => d.Currency)
                    .HasConstraintName("FK_FiyatListesi_Currency");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.FiyatListesiFileNavigation)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_FiyatListesi_File");

                entity.HasOne(d => d.FileDataNavigation)
                    .WithMany(p => p.FiyatListesiFileDataNavigation)
                    .HasForeignKey(d => d.FileData)
                    .HasConstraintName("FK_FiyatListesi_fileData");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.FiyatListesi)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_FiyatListesi_parcalar");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.FiyatListesi)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_FiyatListesi_urunler");
            });

            modelBuilder.Entity<Fotograflar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_Fotograflar");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_Fotograflar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Fotograflar");

                entity.HasIndex(e => e.KapakOpsiyonlari)
                    .HasName("ikapakOpsiyonlari_Fotograflar");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_Fotograflar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Fotograflar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Fotograflar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Fotograflar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Fotograflar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KapakOpsiyonlari).HasColumnName("kapakOpsiyonlari");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_Fotograflar_aksesuar");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_Fotograflar_File");

                entity.HasOne(d => d.KapakOpsiyonlariNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.KapakOpsiyonlari)
                    .HasConstraintName("FK_Fotograflar_kapakOpsiyonlari");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_Fotograflar_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Fotograflar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Fotograflar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Fotograflar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Fotograflar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Fotograflar_urunler");
            });

            modelBuilder.Entity<GizlilikPolitikasi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_GizlilikPolitikasi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Haberler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Haberler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.HaberBaslik).HasMaxLength(100);

                entity.Property(e => e.HaberTarih).HasColumnType("datetime");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<HakkimizdaAltGrup>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_HakkimizdaAltGrup");

                entity.HasIndex(e => e.Hakkimizda)
                    .HasName("iHakkimizda_HakkimizdaAltGrup");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.HakkimizdaNavigation)
                    .WithMany(p => p.HakkimizdaAltGrup)
                    .HasForeignKey(d => d.Hakkimizda)
                    .HasConstraintName("FK_HakkimizdaAltGrup_Hakkimizda");
            });

            modelBuilder.Entity<HakkimizdaVeAltBilgi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_HakkimizdaVeAltBilgi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AltBilgi).IsRequired();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hcategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("HCategory");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_HCategory");

                entity.HasIndex(e => e.Parent)
                    .HasName("iParent_HCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_HCategory_Parent");
            });

            modelBuilder.Entity<HeaderFooter>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_HeaderFooter");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<IdgeneratorTable>(entity =>
            {
                entity.ToTable("IDGeneratorTable");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Prefix).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(254);
            });

            modelBuilder.Entity<IkVizyonPolitika>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("IK_VizyonPolitika");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_IK_VizyonPolitika");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Iletisim>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Iletisim");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EskFax).HasMaxLength(100);

                entity.Property(e => e.EskTelefon).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IstFax).HasMaxLength(100);

                entity.Property(e => e.IstTelefon).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<KaliteDokumanlari>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_KaliteDokumanlari");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iaksesuarGrubu_KaliteDokumanlari");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_KaliteDokumanlari");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KaliteDokumanlari");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_KaliteDokumanlari");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_KaliteDokumanlari");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_KaliteDokumanlari");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_KaliteDokumanlari");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_KaliteDokumanlari");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.AksesuarGrubu).HasColumnName("aksesuarGrubu");

                entity.Property(e => e.ConString)
                    .HasColumnName("conString")
                    .HasMaxLength(100);

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_KaliteDokumanlari_aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_KaliteDokumanlari_aksesuarGrubu");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_KaliteDokumanlari_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_KaliteDokumanlari_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_KaliteDokumanlari_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_KaliteDokumanlari_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_KaliteDokumanlari_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.KaliteDokumanlari)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_KaliteDokumanlari_urunler");
            });

            modelBuilder.Entity<KapakOpsiyonDoc>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.File)
                    .HasName("iFile_KapakOpsiyonDoc");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KapakOpsiyonDoc");

                entity.HasIndex(e => e.KapakOpsiyonlari)
                    .HasName("iKapakOpsiyonlari_KapakOpsiyonDoc");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.KapakOpsiyonDoc)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_KapakOpsiyonDoc_File");

                entity.HasOne(d => d.KapakOpsiyonlariNavigation)
                    .WithMany(p => p.KapakOpsiyonDoc)
                    .HasForeignKey(d => d.KapakOpsiyonlari)
                    .HasConstraintName("FK_KapakOpsiyonDoc_KapakOpsiyonlari");
            });

            modelBuilder.Entity<KapakOpsiyonlari>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KapakOpsiyonlari");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_KapakOpsiyonlari");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_KapakOpsiyonlari");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_KapakOpsiyonlari");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_KapakOpsiyonlari");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Engopsiyon)
                    .HasColumnName("ENGOpsiyon")
                    .HasMaxLength(100);

                entity.Property(e => e.Engweb).HasColumnName("ENGWeb");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Opsiyon).HasMaxLength(100);

                entity.Property(e => e.OpsiyonKodu).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.KapakOpsiyonlari)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_KapakOpsiyonlari_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.KapakOpsiyonlari)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_KapakOpsiyonlari_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.KapakOpsiyonlari)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_KapakOpsiyonlari_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.KapakOpsiyonlari)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_KapakOpsiyonlari_urunler");
            });

            modelBuilder.Entity<Kataloglar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iAksesuar_Kataloglar");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iaksesuarGrubu_Kataloglar");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_Kataloglar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Kataloglar");

                entity.HasIndex(e => e.KataloglarSayfa)
                    .HasName("ikataloglarSayfa_Kataloglar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Kataloglar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Kataloglar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Kataloglar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Kataloglar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AksesuarGrubu).HasColumnName("aksesuarGrubu");

                entity.Property(e => e.EngLklk).HasColumnName("EngLKLK");

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.KatalogAdi).HasMaxLength(100);

                entity.Property(e => e.KataloglarSayfa).HasColumnName("kataloglarSayfa");

                entity.Property(e => e.Lklk).HasColumnName("LKLK");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_Kataloglar_Aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_Kataloglar_aksesuarGrubu");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_Kataloglar_File");

                entity.HasOne(d => d.KataloglarSayfaNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.KataloglarSayfa)
                    .HasConstraintName("FK_Kataloglar_kataloglarSayfa");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Kataloglar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Kataloglar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Kataloglar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Kataloglar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Kataloglar_urunler");
            });

            modelBuilder.Entity<KataloglarSayfasi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KataloglarSayfasi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Baslik).HasMaxLength(100);

                entity.Property(e => e.BaslikEng).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<KlasorDokumanlari>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.File)
                    .HasName("iFile_KlasorDokumanlari");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KlasorDokumanlari");

                entity.HasIndex(e => e.Klasorler)
                    .HasName("iklasorler_KlasorDokumanlari");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Klasorler).HasColumnName("klasorler");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.KlasorDokumanlari)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_KlasorDokumanlari_File");

                entity.HasOne(d => d.KlasorlerNavigation)
                    .WithMany(p => p.KlasorDokumanlari)
                    .HasForeignKey(d => d.Klasorler)
                    .HasConstraintName("FK_KlasorDokumanlari_klasorler");
            });

            modelBuilder.Entity<Klasorler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Klasorler");

                entity.HasIndex(e => e.ParentKlasor)
                    .HasName("iparentKlasor_Klasorler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KlasorAdi).HasMaxLength(100);

                entity.Property(e => e.KlasorKodu).HasMaxLength(100);

                entity.Property(e => e.KlasorTipiEnum).HasColumnName("klasorTipiEnum");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.ParentKlasor).HasColumnName("parentKlasor");

                entity.Property(e => e.ParentKlasorName).HasMaxLength(100);

                entity.HasOne(d => d.ParentKlasorNavigation)
                    .WithMany(p => p.InverseParentKlasorNavigation)
                    .HasForeignKey(d => d.ParentKlasor)
                    .HasConstraintName("FK_Klasorler_parentKlasor");
            });

            modelBuilder.Entity<KpiDefinition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KpiDefinition");

                entity.HasIndex(e => e.KpiInstance)
                    .HasName("iKpiInstance_KpiDefinition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Changed).HasColumnType("datetime");

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Range).HasMaxLength(100);

                entity.Property(e => e.RangeToCompare).HasMaxLength(100);

                entity.Property(e => e.SuppressedSeries).HasMaxLength(100);

                entity.HasOne(d => d.KpiInstanceNavigation)
                    .WithMany(p => p.KpiDefinitionNavigation)
                    .HasForeignKey(d => d.KpiInstance)
                    .HasConstraintName("FK_KpiDefinition_KpiInstance");
            });

            modelBuilder.Entity<KpiHistoryItem>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.KpiInstance)
                    .HasName("iKpiInstance_KpiHistoryItem");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.RangeEnd).HasColumnType("datetime");

                entity.Property(e => e.RangeStart).HasColumnType("datetime");

                entity.HasOne(d => d.KpiInstanceNavigation)
                    .WithMany(p => p.KpiHistoryItem)
                    .HasForeignKey(d => d.KpiInstance)
                    .HasConstraintName("FK_KpiHistoryItem_KpiInstance");
            });

            modelBuilder.Entity<KpiInstance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KpiInstance");

                entity.HasIndex(e => e.KpiDefinition)
                    .HasName("iKpiDefinition_KpiInstance");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ForceMeasurementDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.KpiDefinition1)
                    .WithMany(p => p.KpiInstance1)
                    .HasForeignKey(d => d.KpiDefinition)
                    .HasConstraintName("FK_KpiInstance_KpiDefinition");
            });

            modelBuilder.Entity<KpiScorecard>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KpiScorecard");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<KpiScorecardScorecardsKpiInstanceIndicators>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiScorecardScorecards_KpiInstanceIndicators");

                entity.HasIndex(e => e.Indicators)
                    .HasName("iIndicators_KpiScorecardScorecards_KpiInstanceIndicators");

                entity.HasIndex(e => e.Scorecards)
                    .HasName("iScorecards_KpiScorecardScorecards_KpiInstanceIndicators");

                entity.HasIndex(e => new { e.Indicators, e.Scorecards })
                    .HasName("iIndicatorsScorecards_KpiScorecardScorecards_KpiInstanceIndicators")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IndicatorsNavigation)
                    .WithMany(p => p.KpiScorecardScorecardsKpiInstanceIndicators)
                    .HasForeignKey(d => d.Indicators)
                    .HasConstraintName("FK_KpiScorecardScorecards_KpiInstanceIndicators_Indicators");

                entity.HasOne(d => d.ScorecardsNavigation)
                    .WithMany(p => p.KpiScorecardScorecardsKpiInstanceIndicators)
                    .HasForeignKey(d => d.Scorecards)
                    .HasConstraintName("FK_KpiScorecardScorecards_KpiInstanceIndicators_Scorecards");
            });

            modelBuilder.Entity<KurumsalLogoKullanimi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Enkatalog)
                    .HasName("iENKatalog_KurumsalLogoKullanimi");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_KurumsalLogoKullanimi");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_KurumsalLogoKullanimi");

                entity.HasIndex(e => e.Katalog)
                    .HasName("iKatalog_KurumsalLogoKullanimi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.Enadi)
                    .HasColumnName("ENAdi")
                    .HasMaxLength(100);

                entity.Property(e => e.Enkatalog).HasColumnName("ENKatalog");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.EnkatalogNavigation)
                    .WithMany(p => p.KurumsalLogoKullanimiEnkatalogNavigation)
                    .HasForeignKey(d => d.Enkatalog)
                    .HasConstraintName("FK_KurumsalLogoKullanimi_ENKatalog");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.KurumsalLogoKullanimiFileNavigation)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_KurumsalLogoKullanimi_File");

                entity.HasOne(d => d.KatalogNavigation)
                    .WithMany(p => p.KurumsalLogoKullanimiKatalogNavigation)
                    .HasForeignKey(d => d.Katalog)
                    .HasConstraintName("FK_KurumsalLogoKullanimi_Katalog");
            });

            modelBuilder.Entity<Logolar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Logolar");

                entity.HasIndex(e => e.KaliteDokumanlari)
                    .HasName("ikaliteDokumanlari_Logolar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KaliteDokumanlari).HasColumnName("kaliteDokumanlari");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.KaliteDokumanlariNavigation)
                    .WithMany(p => p.Logolar)
                    .HasForeignKey(d => d.KaliteDokumanlari)
                    .HasConstraintName("FK_Logolar_kaliteDokumanlari");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Material");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Malzeme).HasMaxLength(100);
            });

            modelBuilder.Entity<MediaDataObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_MediaDataObject");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_MediaDataObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MediaDataKey).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.MediaDataObject)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_MediaDataObject_ObjectType");
            });

            modelBuilder.Entity<ModelDifference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ModelDifference");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ContextId).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<ModelDifferenceAspect>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ModelDifferenceAspect");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_ModelDifferenceAspect");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.ModelDifferenceAspect)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_ModelDifferenceAspect_Owner");
            });

            modelBuilder.Entity<MontajKlavuzlari>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_MontajKlavuzlari");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iaksesuarGrubu_MontajKlavuzlari");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_MontajKlavuzlari");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_MontajKlavuzlari");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_MontajKlavuzlari");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_MontajKlavuzlari");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_MontajKlavuzlari");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_MontajKlavuzlari");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_MontajKlavuzlari");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.AksesuarGrubu).HasColumnName("aksesuarGrubu");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_MontajKlavuzlari_aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_MontajKlavuzlari_aksesuarGrubu");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_MontajKlavuzlari_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_MontajKlavuzlari_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_MontajKlavuzlari_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_MontajKlavuzlari_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_MontajKlavuzlari_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.MontajKlavuzlari)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_MontajKlavuzlari_urunler");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Note");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<OnayBekleyenDokumanlar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.File)
                    .HasName("iFile_OnayBekleyenDokumanlar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_OnayBekleyenDokumanlar");

                entity.HasIndex(e => e.UserMid2)
                    .HasName("iUserMid2_OnayBekleyenDokumanlar");

                entity.HasIndex(e => e.Yetkilendirme)
                    .HasName("iyetkilendirme_OnayBekleyenDokumanlar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DokumanOlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.DokumanOlusturulmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.DokumanOnaylanmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ObjectType).HasMaxLength(100);

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.UrunAilesi)
                    .HasColumnName("urunAilesi")
                    .HasMaxLength(100);

                entity.Property(e => e.UrunGrubu)
                    .HasColumnName("urunGrubu")
                    .HasMaxLength(100);

                entity.Property(e => e.UrunSerisi)
                    .HasColumnName("urunSerisi")
                    .HasMaxLength(100);

                entity.Property(e => e.Urunler)
                    .HasColumnName("urunler")
                    .HasMaxLength(100);

                entity.Property(e => e.Yetkilendirme).HasColumnName("yetkilendirme");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.OnayBekleyenDokumanlar)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_OnayBekleyenDokumanlar_File");

                entity.HasOne(d => d.UserMid2Navigation)
                    .WithMany(p => p.OnayBekleyenDokumanlar)
                    .HasForeignKey(d => d.UserMid2)
                    .HasConstraintName("FK_OnayBekleyenDokumanlar_UserMid2");

                entity.HasOne(d => d.YetkilendirmeNavigation)
                    .WithMany(p => p.OnayBekleyenDokumanlar)
                    .HasForeignKey(d => d.Yetkilendirme)
                    .HasConstraintName("FK_OnayBekleyenDokumanlar_yetkilendirme");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Profile).HasMaxLength(100);

                entity.Property(e => e.WebSite).HasMaxLength(100);

                entity.HasOne(d => d.O)
                    .WithOne(p => p.Organization)
                    .HasForeignKey<Organization>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organization_Oid");
            });

            modelBuilder.Entity<OtoKodTanim>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_OtoKodTanim");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KodOnTanim)
                    .HasColumnName("kod_on_tanim")
                    .HasMaxLength(100);

                entity.Property(e => e.ObjeAdi)
                    .HasColumnName("obje_adi")
                    .HasMaxLength(100);

                entity.Property(e => e.ObjectType).HasMaxLength(100);

                entity.Property(e => e.Uzunluk).HasColumnName("uzunluk");
            });

            modelBuilder.Entity<Ozellikler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Ozellikler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EngOzellikAdi).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.OzellikAdi).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Parcalar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Parcalar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Parcalar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Parcalar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Parcalar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Parcalar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.ParcaAdi).HasMaxLength(100);

                entity.Property(e => e.ParcaKodu).HasMaxLength(100);

                entity.Property(e => e.SeriKisaKodu).HasMaxLength(100);

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Parcalar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Parcalar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Parcalar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Parcalar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Parcalar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Parcalar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Parcalar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Parcalar_urunler");
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Address1)
                    .HasName("iAddress1_Party");

                entity.HasIndex(e => e.Address2)
                    .HasName("iAddress2_Party");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Party");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_Party");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.Address1Navigation)
                    .WithMany(p => p.PartyAddress1Navigation)
                    .HasForeignKey(d => d.Address1)
                    .HasConstraintName("FK_Party_Address1");

                entity.HasOne(d => d.Address2Navigation)
                    .WithMany(p => p.PartyAddress2Navigation)
                    .HasForeignKey(d => d.Address2)
                    .HasConstraintName("FK_Party_Address2");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.Party)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_Party_ObjectType");
            });

            modelBuilder.Entity<PermissionPolicyMemberPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyMemberPermissionsObject");

                entity.HasIndex(e => e.TypePermissionObject)
                    .HasName("iTypePermissionObject_PermissionPolicyMemberPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.TypePermissionObjectNavigation)
                    .WithMany(p => p.PermissionPolicyMemberPermissionsObject)
                    .HasForeignKey(d => d.TypePermissionObject)
                    .HasConstraintName("FK_PermissionPolicyMemberPermissionsObject_TypePermissionObject");
            });

            modelBuilder.Entity<PermissionPolicyNavigationPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyNavigationPermissionsObject");

                entity.HasIndex(e => e.Role)
                    .HasName("iRole_PermissionPolicyNavigationPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.PermissionPolicyNavigationPermissionsObject)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_PermissionPolicyNavigationPermissionsObject_Role");
            });

            modelBuilder.Entity<PermissionPolicyObjectPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyObjectPermissionsObject");

                entity.HasIndex(e => e.TypePermissionObject)
                    .HasName("iTypePermissionObject_PermissionPolicyObjectPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.TypePermissionObjectNavigation)
                    .WithMany(p => p.PermissionPolicyObjectPermissionsObject)
                    .HasForeignKey(d => d.TypePermissionObject)
                    .HasConstraintName("FK_PermissionPolicyObjectPermissionsObject_TypePermissionObject");
            });

            modelBuilder.Entity<PermissionPolicyRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyRole");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_PermissionPolicyRole");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.PermissionPolicyRole)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_PermissionPolicyRole_ObjectType");
            });

            modelBuilder.Entity<PermissionPolicyTypePermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyTypePermissionsObject");

                entity.HasIndex(e => e.Role)
                    .HasName("iRole_PermissionPolicyTypePermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.PermissionPolicyTypePermissionsObject)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_PermissionPolicyTypePermissionsObject_Role");
            });

            modelBuilder.Entity<PermissionPolicyUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PermissionPolicyUser");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_PermissionPolicyUser");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.PermissionPolicyUser)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_PermissionPolicyUser_ObjectType");
            });

            modelBuilder.Entity<PermissionPolicyUserUsersPermissionPolicyRoleRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.HasIndex(e => e.Roles)
                    .HasName("iRoles_PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.HasIndex(e => new { e.Roles, e.Users })
                    .HasName("iRolesUsers_PermissionPolicyUserUsers_PermissionPolicyRoleRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.PermissionPolicyUserUsersPermissionPolicyRoleRoles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_PermissionPolicyUserUsers_PermissionPolicyRoleRoles_Roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.PermissionPolicyUserUsersPermissionPolicyRoleRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_PermissionPolicyUserUsers_PermissionPolicyRoleRoles_Users");
            });

            modelBuilder.Entity<PersistentPermission>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PersistentPermission");

                entity.HasIndex(e => e.Role)
                    .HasName("iRole_PersistentPermission");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SerializedPermission).HasMaxLength(4000);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.PersistentPermission)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_PersistentPermission_Role");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.HasOne(d => d.O)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_Oid");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PhoneNumber");

                entity.HasIndex(e => e.Party)
                    .HasName("iParty_PhoneNumber");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Number).HasMaxLength(100);

                entity.Property(e => e.PhoneType).HasMaxLength(100);

                entity.HasOne(d => d.PartyNavigation)
                    .WithMany(p => p.PhoneNumber)
                    .HasForeignKey(d => d.Party)
                    .HasConstraintName("FK_PhoneNumber_Party");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PhoneType");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<PropertyBag>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PropertyBag");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<PropertyBagDescriptor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PropertyBagDescriptor");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<PropertyDescriptor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_PropertyDescriptor")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PropertyDescriptor");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(4);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

                entity.HasIndex(e => e.PropertyBags)
                    .HasName("iPropertyBags_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

                entity.HasIndex(e => e.PropertyDescriptors)
                    .HasName("iPropertyDescriptors_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

                entity.HasIndex(e => new { e.PropertyBags, e.PropertyDescriptors })
                    .HasName("iPropertyBagsPropertyDescriptors_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PropertyBagsNavigation)
                    .WithMany(p => p.PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags)
                    .HasForeignKey(d => d.PropertyBags)
                    .HasConstraintName("FK_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags_PropertyBags");

                entity.HasOne(d => d.PropertyDescriptorsNavigation)
                    .WithMany(p => p.PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags)
                    .HasForeignKey(d => d.PropertyDescriptors)
                    .HasConstraintName("FK_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags_PropertyDescriptors");
            });

            modelBuilder.Entity<PropertyValue>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Bag)
                    .HasName("iBag_PropertyValue");

                entity.HasIndex(e => e.Descriptor)
                    .HasName("iDescriptor_PropertyValue");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PropertyValue");

                entity.HasIndex(e => e.WeakReference)
                    .HasName("iWeakReference_PropertyValue");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.StrValue).HasMaxLength(100);

                entity.HasOne(d => d.BagNavigation)
                    .WithMany(p => p.PropertyValue)
                    .HasForeignKey(d => d.Bag)
                    .HasConstraintName("FK_PropertyValue_Bag");

                entity.HasOne(d => d.DescriptorNavigation)
                    .WithMany(p => p.PropertyValue)
                    .HasForeignKey(d => d.Descriptor)
                    .HasConstraintName("FK_PropertyValue_Descriptor");

                entity.HasOne(d => d.WeakReferenceNavigation)
                    .WithMany(p => p.PropertyValue)
                    .HasForeignKey(d => d.WeakReference)
                    .HasConstraintName("FK_PropertyValue_WeakReference");
            });

            modelBuilder.Entity<Reklamlar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Reklamlar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Baslik).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<Renk>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Renk");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EngRenk).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Renk1)
                    .HasColumnName("renk")
                    .HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReportData>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ReportData");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ObjectTypeName).HasMaxLength(512);
            });

            modelBuilder.Entity<ReportDataV2>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ReportDataV2");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ObjectTypeName).HasMaxLength(512);

                entity.Property(e => e.ParametersObjectTypeName).HasMaxLength(512);

                entity.Property(e => e.PredefinedReportType).HasMaxLength(512);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Resource");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<ResourceResourcesEventEvents>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ResourceResources_EventEvents");

                entity.HasIndex(e => e.Events)
                    .HasName("iEvents_ResourceResources_EventEvents");

                entity.HasIndex(e => e.Resources)
                    .HasName("iResources_ResourceResources_EventEvents");

                entity.HasIndex(e => new { e.Events, e.Resources })
                    .HasName("iEventsResources_ResourceResources_EventEvents")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EventsNavigation)
                    .WithMany(p => p.ResourceResourcesEventEvents)
                    .HasForeignKey(d => d.Events)
                    .HasConstraintName("FK_ResourceResources_EventEvents_Events");

                entity.HasOne(d => d.ResourcesNavigation)
                    .WithMany(p => p.ResourceResourcesEventEvents)
                    .HasForeignKey(d => d.Resources)
                    .HasConstraintName("FK_ResourceResources_EventEvents_Resources");
            });

            modelBuilder.Entity<RevizeNedenleri>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_RevizeNedenleri");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.RevizeNedeni).HasMaxLength(100);
            });

            modelBuilder.Entity<Revizeler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.DigerDokumanlar)
                    .HasName("idigerDokumanlar_Revizeler");

                entity.HasIndex(e => e.Fotograflar)
                    .HasName("ifotograflar_Revizeler");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Revizeler");

                entity.HasIndex(e => e.KaliteDokumanlari)
                    .HasName("ikaliteDokumanlari_Revizeler");

                entity.HasIndex(e => e.KlasorDokumanlari)
                    .HasName("iklasorDokumanlari_Revizeler");

                entity.HasIndex(e => e.MontajKlavuzlari)
                    .HasName("iMontajKlavuzlari_Revizeler");

                entity.HasIndex(e => e.RevizeDokuman)
                    .HasName("iRevizeDokuman_Revizeler");

                entity.HasIndex(e => e.RevizeNedenleri)
                    .HasName("iRevizeNedenleri_Revizeler");

                entity.HasIndex(e => e.SertifikaDoc)
                    .HasName("isertifikaDoc_Revizeler");

                entity.HasIndex(e => e.SertifikaDokumanlari)
                    .HasName("isertifikaDokumanlari_Revizeler");

                entity.HasIndex(e => e.TeknikCizimler)
                    .HasName("iteknikCizimler_Revizeler");

                entity.HasIndex(e => e.TeknikSartname)
                    .HasName("iteknikSartname_Revizeler");

                entity.HasIndex(e => e.UretimDokumanlari)
                    .HasName("iuretimDokumanlari_Revizeler");

                entity.HasIndex(e => e.YeniDokuman)
                    .HasName("iYeniDokuman_Revizeler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DigerDokumanlar).HasColumnName("digerDokumanlar");

                entity.Property(e => e.Fotograflar).HasColumnName("fotograflar");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KaliteDokumanlari).HasColumnName("kaliteDokumanlari");

                entity.Property(e => e.KlasorDokumanlari).HasColumnName("klasorDokumanlari");

                entity.Property(e => e.RevizeEdenKisi).HasMaxLength(100);

                entity.Property(e => e.RevizeNedeni).HasMaxLength(100);

                entity.Property(e => e.RevizeTarihi).HasColumnType("datetime");

                entity.Property(e => e.SertifikaDoc).HasColumnName("sertifikaDoc");

                entity.Property(e => e.SertifikaDokumanlari).HasColumnName("sertifikaDokumanlari");

                entity.Property(e => e.TeknikCizimler).HasColumnName("teknikCizimler");

                entity.Property(e => e.TeknikSartname).HasColumnName("teknikSartname");

                entity.Property(e => e.UretimDokumanlari).HasColumnName("uretimDokumanlari");

                entity.HasOne(d => d.DigerDokumanlarNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.DigerDokumanlar)
                    .HasConstraintName("FK_Revizeler_digerDokumanlar");

                entity.HasOne(d => d.FotograflarNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.Fotograflar)
                    .HasConstraintName("FK_Revizeler_fotograflar");

                entity.HasOne(d => d.KaliteDokumanlariNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.KaliteDokumanlari)
                    .HasConstraintName("FK_Revizeler_kaliteDokumanlari");

                entity.HasOne(d => d.KlasorDokumanlariNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.KlasorDokumanlari)
                    .HasConstraintName("FK_Revizeler_klasorDokumanlari");

                entity.HasOne(d => d.MontajKlavuzlariNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.MontajKlavuzlari)
                    .HasConstraintName("FK_Revizeler_MontajKlavuzlari");

                entity.HasOne(d => d.RevizeDokumanNavigation)
                    .WithMany(p => p.RevizelerRevizeDokumanNavigation)
                    .HasForeignKey(d => d.RevizeDokuman)
                    .HasConstraintName("FK_Revizeler_RevizeDokuman");

                entity.HasOne(d => d.RevizeNedenleriNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.RevizeNedenleri)
                    .HasConstraintName("FK_Revizeler_RevizeNedenleri");

                entity.HasOne(d => d.SertifikaDokumanlariNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.SertifikaDokumanlari)
                    .HasConstraintName("FK_Revizeler_sertifikaDokumanlari");

                entity.HasOne(d => d.TeknikCizimlerNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.TeknikCizimler)
                    .HasConstraintName("FK_Revizeler_teknikCizimler");

                entity.HasOne(d => d.TeknikSartnameNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.TeknikSartname)
                    .HasConstraintName("FK_Revizeler_teknikSartname");

                entity.HasOne(d => d.UretimDokumanlariNavigation)
                    .WithMany(p => p.Revizeler)
                    .HasForeignKey(d => d.UretimDokumanlari)
                    .HasConstraintName("FK_Revizeler_uretimDokumanlari");

                entity.HasOne(d => d.YeniDokumanNavigation)
                    .WithMany(p => p.RevizelerYeniDokumanNavigation)
                    .HasForeignKey(d => d.YeniDokuman)
                    .HasConstraintName("FK_Revizeler_YeniDokuman");
            });

            modelBuilder.Entity<RichTextMailMergeData>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_RichTextMailMergeData");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.O)
                    .WithOne(p => p.Role)
                    .HasForeignKey<Role>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Oid");
            });

            modelBuilder.Entity<RoleBase>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_RoleBase");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_RoleBase");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.RoleBase)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_RoleBase_ObjectType");
            });

            modelBuilder.Entity<SecuritySystemMemberPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemMemberPermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemMemberPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemMemberPermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemMemberPermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemObjectPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemObjectPermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemObjectPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemObjectPermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemObjectPermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemRole");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemRole");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemRole)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemRole_ObjectType");
            });

            modelBuilder.Entity<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => e.ChildRoles)
                    .HasName("iChildRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => e.ParentRoles)
                    .HasName("iParentRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => new { e.ChildRoles, e.ParentRoles })
                    .HasName("iChildRolesParentRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ChildRolesNavigation)
                    .WithMany(p => p.SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesChildRolesNavigation)
                    .HasForeignKey(d => d.ChildRoles)
                    .HasConstraintName("FK_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles_ChildRoles");

                entity.HasOne(d => d.ParentRolesNavigation)
                    .WithMany(p => p.SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesParentRolesNavigation)
                    .HasForeignKey(d => d.ParentRoles)
                    .HasConstraintName("FK_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles_ParentRoles");
            });

            modelBuilder.Entity<SecuritySystemTypePermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemTypePermissionsObject");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemTypePermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemTypePermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemTypePermissionsObject)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemTypePermissionsObject_ObjectType");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemTypePermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemTypePermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemUser");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemUser");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemUser)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemUser_ObjectType");
            });

            modelBuilder.Entity<SecuritySystemUserUsersSecuritySystemRoleRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => e.Roles)
                    .HasName("iRoles_SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => new { e.Roles, e.Users })
                    .HasName("iRolesUsers_SecuritySystemUserUsers_SecuritySystemRoleRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.SecuritySystemUserUsersSecuritySystemRoleRoles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_SecuritySystemUserUsers_SecuritySystemRoleRoles_Roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.SecuritySystemUserUsersSecuritySystemRoleRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_SecuritySystemUserUsers_SecuritySystemRoleRoles_Users");
            });

            modelBuilder.Entity<Sertifikalar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_Sertifikalar");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iaksesuarGrubu_Sertifikalar");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_Sertifikalar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Sertifikalar");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_Sertifikalar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Sertifikalar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Sertifikalar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Sertifikalar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Sertifikalar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.AksesuarGrubu).HasColumnName("aksesuarGrubu");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Lklk).HasColumnName("LKLK");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_Sertifikalar_aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_Sertifikalar_aksesuarGrubu");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_Sertifikalar_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_Sertifikalar_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Sertifikalar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Sertifikalar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Sertifikalar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Sertifikalar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Sertifikalar_urunler");
            });

            modelBuilder.Entity<ServerPrefix>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ServerPrefix");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Prefix).HasMaxLength(100);
            });

            modelBuilder.Entity<SimpleUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SimpleUser");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_State");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.LongName).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);
            });

            modelBuilder.Entity<Taglar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_Taglar");

                entity.HasIndex(e => e.DigerDokumanlar)
                    .HasName("idigerDokumanlar_Taglar");

                entity.HasIndex(e => e.Fotograflar)
                    .HasName("ifotograflar_Taglar");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Taglar");

                entity.HasIndex(e => e.KaliteDokumanlari)
                    .HasName("ikaliteDokumanlari_Taglar");

                entity.HasIndex(e => e.KapakOpsiyonlari)
                    .HasName("ikapakOpsiyonlari_Taglar");

                entity.HasIndex(e => e.KlasorDokumanlari)
                    .HasName("iklasorDokumanlari_Taglar");

                entity.HasIndex(e => e.MontajKlavuzlari)
                    .HasName("imontajKlavuzlari_Taglar");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_Taglar");

                entity.HasIndex(e => e.SertifikaDoc)
                    .HasName("isertifikaDoc_Taglar");

                entity.HasIndex(e => e.SertifikaDokumanlari)
                    .HasName("isertifikaDokumanlari_Taglar");

                entity.HasIndex(e => e.TeknikCizimler)
                    .HasName("iteknikCizimler_Taglar");

                entity.HasIndex(e => e.TeknikSartname)
                    .HasName("iteknikSartname_Taglar");

                entity.HasIndex(e => e.UretimDokumanlari)
                    .HasName("iuretimDokumanlari_Taglar");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Taglar");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Taglar");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Taglar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Taglar");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.DigerDokumanlar).HasColumnName("digerDokumanlar");

                entity.Property(e => e.Fotograflar).HasColumnName("fotograflar");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.KaliteDokumanlari).HasColumnName("kaliteDokumanlari");

                entity.Property(e => e.KapakOpsiyonlari).HasColumnName("kapakOpsiyonlari");

                entity.Property(e => e.KlasorDokumanlari).HasColumnName("klasorDokumanlari");

                entity.Property(e => e.MontajKlavuzlari).HasColumnName("montajKlavuzlari");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.SertifikaDoc).HasColumnName("sertifikaDoc");

                entity.Property(e => e.SertifikaDokumanlari).HasColumnName("sertifikaDokumanlari");

                entity.Property(e => e.Tag).HasMaxLength(100);

                entity.Property(e => e.TeknikCizimler).HasColumnName("teknikCizimler");

                entity.Property(e => e.TeknikSartname).HasColumnName("teknikSartname");

                entity.Property(e => e.UretimDokumanlari).HasColumnName("uretimDokumanlari");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_Taglar_aksesuar");

                entity.HasOne(d => d.DigerDokumanlarNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.DigerDokumanlar)
                    .HasConstraintName("FK_Taglar_digerDokumanlar");

                entity.HasOne(d => d.FotograflarNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.Fotograflar)
                    .HasConstraintName("FK_Taglar_fotograflar");

                entity.HasOne(d => d.KaliteDokumanlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.KaliteDokumanlari)
                    .HasConstraintName("FK_Taglar_kaliteDokumanlari");

                entity.HasOne(d => d.KapakOpsiyonlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.KapakOpsiyonlari)
                    .HasConstraintName("FK_Taglar_kapakOpsiyonlari");

                entity.HasOne(d => d.KlasorDokumanlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.KlasorDokumanlari)
                    .HasConstraintName("FK_Taglar_klasorDokumanlari");

                entity.HasOne(d => d.MontajKlavuzlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.MontajKlavuzlari)
                    .HasConstraintName("FK_Taglar_montajKlavuzlari");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_Taglar_parcalar");

                entity.HasOne(d => d.SertifikaDokumanlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.SertifikaDokumanlari)
                    .HasConstraintName("FK_Taglar_sertifikaDokumanlari");

                entity.HasOne(d => d.TeknikCizimlerNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.TeknikCizimler)
                    .HasConstraintName("FK_Taglar_teknikCizimler");

                entity.HasOne(d => d.TeknikSartnameNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.TeknikSartname)
                    .HasConstraintName("FK_Taglar_teknikSartname");

                entity.HasOne(d => d.UretimDokumanlariNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.UretimDokumanlari)
                    .HasConstraintName("FK_Taglar_uretimDokumanlari");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Taglar_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Taglar_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Taglar_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.Taglar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Taglar_urunler");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AssignedTo)
                    .HasName("iAssignedTo_Task");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Task");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("FK_Task_AssignedTo");
            });

            modelBuilder.Entity<TeknikCizimler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_TeknikCizimler");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iaksesuarGrubu_TeknikCizimler");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_TeknikCizimler");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_TeknikCizimler");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_TeknikCizimler");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_TeknikCizimler");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_TeknikCizimler");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_TeknikCizimler");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_TeknikCizimler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.AksesuarGrubu).HasColumnName("aksesuarGrubu");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_TeknikCizimler_aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_TeknikCizimler_aksesuarGrubu");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_TeknikCizimler_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_TeknikCizimler_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_TeknikCizimler_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_TeknikCizimler_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_TeknikCizimler_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.TeknikCizimler)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_TeknikCizimler_urunler");
            });

            modelBuilder.Entity<TeknikSartname>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_TeknikSartname");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_TeknikSartname");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_TeknikSartname");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_TeknikSartname");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_TeknikSartname");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_TeknikSartname");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_TeknikSartname");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.EngWebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_TeknikSartname_aksesuar");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_TeknikSartname_File");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_TeknikSartname_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_TeknikSartname_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_TeknikSartname_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.TeknikSartname)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_TeknikSartname_urunler");
            });

            modelBuilder.Entity<Update>(entity =>
            {
                entity.Property(e => e.UpdateId).HasColumnName("Update_ID");

                entity.Property(e => e.AutoManual).HasMaxLength(1);

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<UretimDokumanlari>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_UretimDokumanlari");

                entity.HasIndex(e => e.File)
                    .HasName("iFile_UretimDokumanlari");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UretimDokumanlari");

                entity.HasIndex(e => e.Parcalar)
                    .HasName("iparcalar_UretimDokumanlari");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_UretimDokumanlari");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_UretimDokumanlari");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_UretimDokumanlari");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_UretimDokumanlari");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.DokumanAdi).HasMaxLength(100);

                entity.Property(e => e.DokumanUzanti)
                    .HasColumnName("dokumanUzanti")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Onay).HasColumnName("onay");

                entity.Property(e => e.Parcalar).HasColumnName("parcalar");

                entity.Property(e => e.Red).HasColumnName("red");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.Property(e => e.WebDokumanAdi).HasMaxLength(100);

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_UretimDokumanlari_aksesuar");

                entity.HasOne(d => d.FileNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.File)
                    .HasConstraintName("FK_UretimDokumanlari_File");

                entity.HasOne(d => d.ParcalarNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.Parcalar)
                    .HasConstraintName("FK_UretimDokumanlari_parcalar");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_UretimDokumanlari_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_UretimDokumanlari_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_UretimDokumanlari_urunSerisi");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.UretimDokumanlari)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_UretimDokumanlari_urunler");
            });

            modelBuilder.Entity<UrunAilesi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UrunAilesi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EngUrunAilesiAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesiAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);
            });

            modelBuilder.Entity<UrunDegerler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Degerler)
                    .HasName("idegerler_UrunDegerler");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UrunDegerler");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_UrunDegerler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Deger).HasMaxLength(100);

                entity.Property(e => e.Degerler).HasColumnName("degerler");

                entity.Property(e => e.EngDeger).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.DegerlerNavigation)
                    .WithMany(p => p.UrunDegerler)
                    .HasForeignKey(d => d.Degerler)
                    .HasConstraintName("FK_UrunDegerler_degerler");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.UrunDegerler)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_UrunDegerler_urunler");
            });

            modelBuilder.Entity<UrunGrubu>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UrunGrubu");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_UrunGrubu");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EngUrunGrubuAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubuAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.UrunGrubu)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_UrunGrubu_urunAilesi");
            });

            modelBuilder.Entity<UrunSerisi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UrunSerisi");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_UrunSerisi");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_UrunSerisi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EngUrunSerisiAdi).HasMaxLength(100);

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisiAdi).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.UrunSerisi)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_UrunSerisi_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.UrunSerisi)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_UrunSerisi_urunGrubu");
            });

            modelBuilder.Entity<UrunTeknikSartname>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Urun_TeknikSartname");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Urun_TeknikSartname");

                entity.HasIndex(e => e.TeknikSarnameler)
                    .HasName("iTeknikSarnameler_Urun_TeknikSartname");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iUrunler_Urun_TeknikSartname");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.TeknikSarnamelerNavigation)
                    .WithMany(p => p.UrunTeknikSartname)
                    .HasForeignKey(d => d.TeknikSarnameler)
                    .HasConstraintName("FK_Urun_TeknikSartname_TeknikSarnameler");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.UrunTeknikSartname)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Urun_TeknikSartname_Urunler");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Boyut)
                    .HasName("iboyut_Urunler");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Urunler");

                entity.HasIndex(e => e.Renk)
                    .HasName("irenk_Urunler");

                entity.HasIndex(e => e.UrunAilesi)
                    .HasName("iurunAilesi_Urunler");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iurunGrubu_Urunler");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iurunSerisi_Urunler");

                entity.HasIndex(e => e.Yukseklik)
                    .HasName("iyukseklik_Urunler");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AltUrunGrubu).HasMaxLength(100);

                entity.Property(e => e.AltUrunTipi).HasMaxLength(100);

                entity.Property(e => e.AnaUrunGrubu).HasMaxLength(100);

                entity.Property(e => e.Barkod).HasMaxLength(100);

                entity.Property(e => e.Birim).HasMaxLength(100);

                entity.Property(e => e.Boyut).HasColumnName("boyut");

                entity.Property(e => e.EngWebUrl).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IlkFoto).HasColumnName("ilkFoto");

                entity.Property(e => e.KatalogKodu).HasMaxLength(100);

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Renk).HasColumnName("renk");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.StokAdi).HasMaxLength(100);

                entity.Property(e => e.StokKodu).HasMaxLength(100);

                entity.Property(e => e.UrunAilesi).HasColumnName("urunAilesi");

                entity.Property(e => e.UrunCinsi).HasMaxLength(100);

                entity.Property(e => e.UrunGrubu).HasColumnName("urunGrubu");

                entity.Property(e => e.UrunSerisi).HasColumnName("urunSerisi");

                entity.Property(e => e.UrunTuru).HasMaxLength(100);

                entity.Property(e => e.WebUrl).HasMaxLength(100);

                entity.Property(e => e.Yukseklik).HasColumnName("yukseklik");

                entity.HasOne(d => d.BoyutNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.Boyut)
                    .HasConstraintName("FK_Urunler_boyut");

                entity.HasOne(d => d.RenkNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.Renk)
                    .HasConstraintName("FK_Urunler_renk");

                entity.HasOne(d => d.UrunAilesiNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.UrunAilesi)
                    .HasConstraintName("FK_Urunler_urunAilesi");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_Urunler_urunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_Urunler_urunSerisi");

                entity.HasOne(d => d.YukseklikNavigation)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.Yukseklik)
                    .HasConstraintName("FK_Urunler_yukseklik");
            });

            modelBuilder.Entity<UrunlerurunlerAksesuaraksesuar>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Urunlerurunler_Aksesuaraksesuar");

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iaksesuar_Urunlerurunler_Aksesuaraksesuar");

                entity.HasIndex(e => e.Urunler)
                    .HasName("iurunler_Urunlerurunler_Aksesuaraksesuar");

                entity.HasIndex(e => new { e.Aksesuar, e.Urunler })
                    .HasName("iaksesuarurunler_Urunlerurunler_Aksesuaraksesuar")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aksesuar).HasColumnName("aksesuar");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Urunler).HasColumnName("urunler");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.UrunlerurunlerAksesuaraksesuar)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_Urunlerurunler_Aksesuaraksesuar_aksesuar");

                entity.HasOne(d => d.UrunlerNavigation)
                    .WithMany(p => p.UrunlerurunlerAksesuaraksesuar)
                    .HasForeignKey(d => d.Urunler)
                    .HasConstraintName("FK_Urunlerurunler_Aksesuaraksesuar_urunler");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.StoredPassword).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.O)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Oid");
            });

            modelBuilder.Entity<UserMid2>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Departmanlar)
                    .HasName("idepartmanlar_UserMid2");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AdiSoyadi).HasMaxLength(100);

                entity.Property(e => e.Departmanlar).HasColumnName("departmanlar");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departmanlar1)
                    .WithMany(p => p.UserMid2)
                    .HasForeignKey(d => d.Departmanlar)
                    .HasConstraintName("FK_UserMid2_departmanlar");

                entity.HasOne(d => d.O)
                    .WithOne(p => p.UserMid2)
                    .HasForeignKey<UserMid2>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMid2_Oid");
            });

            modelBuilder.Entity<UserUsersRoleRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("UserUsers_RoleRoles");

                entity.HasIndex(e => e.Roles)
                    .HasName("iRoles_UserUsers_RoleRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_UserUsers_RoleRoles");

                entity.HasIndex(e => new { e.Roles, e.Users })
                    .HasName("iRolesUsers_UserUsers_RoleRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.UserUsersRoleRoles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_UserUsers_RoleRoles_Roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.UserUsersRoleRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_UserUsers_RoleRoles_Users");
            });

            modelBuilder.Entity<VideolarSayfasi>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_VideolarSayfasi");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Baslik).HasMaxLength(100);

                entity.Property(e => e.BaslikEng).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebFotograf>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Aksesuar)
                    .HasName("iAksesuar_WebFotograf");

                entity.HasIndex(e => e.AksesuarGrubu)
                    .HasName("iAksesuarGrubu_WebFotograf");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_WebFotograf");

                entity.HasIndex(e => e.KaliteliFotografOid)
                    .HasName("iKaliteliFotografOid_WebFotograf");

                entity.HasIndex(e => e.Urun)
                    .HasName("iUrun_WebFotograf");

                entity.HasIndex(e => e.UrunGrubu)
                    .HasName("iUrunGrubu_WebFotograf");

                entity.HasIndex(e => e.UrunSerisi)
                    .HasName("iUrunSerisi_WebFotograf");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.AksesuarNavigation)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.Aksesuar)
                    .HasConstraintName("FK_WebFotograf_Aksesuar");

                entity.HasOne(d => d.AksesuarGrubuNavigation)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.AksesuarGrubu)
                    .HasConstraintName("FK_WebFotograf_AksesuarGrubu");

                entity.HasOne(d => d.KaliteliFotografO)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.KaliteliFotografOid)
                    .HasConstraintName("FK_WebFotograf_KaliteliFotografOid");

                entity.HasOne(d => d.UrunNavigation)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.Urun)
                    .HasConstraintName("FK_WebFotograf_Urun");

                entity.HasOne(d => d.UrunGrubuNavigation)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.UrunGrubu)
                    .HasConstraintName("FK_WebFotograf_UrunGrubu");

                entity.HasOne(d => d.UrunSerisiNavigation)
                    .WithMany(p => p.WebFotograf)
                    .HasForeignKey(d => d.UrunSerisi)
                    .HasConstraintName("FK_WebFotograf_UrunSerisi");
            });

            modelBuilder.Entity<XpoInstanceKey>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoInstanceKey");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<XpoRunningWorkflowInstanceInfo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoRunningWorkflowInstanceInfo");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.TargetObjectHandle).HasMaxLength(255);

                entity.Property(e => e.WorkflowName).HasMaxLength(255);

                entity.Property(e => e.WorkflowUniqueId).HasMaxLength(255);
            });

            modelBuilder.Entity<XpoStartWorkflowRequest>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoStartWorkflowRequest");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetObjectKey).HasMaxLength(100);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);

                entity.Property(e => e.TargetWorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoState>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoState");

                entity.HasIndex(e => e.StateMachine)
                    .HasName("iStateMachine_XpoState");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.StateMachineNavigation)
                    .WithMany(p => p.XpoState)
                    .HasForeignKey(d => d.StateMachine)
                    .HasConstraintName("FK_XpoState_StateMachine");
            });

            modelBuilder.Entity<XpoStateAppearance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoStateAppearance");

                entity.HasIndex(e => e.State)
                    .HasName("iState_XpoStateAppearance");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AppearanceItemType).HasMaxLength(100);

                entity.Property(e => e.Context).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Method).HasMaxLength(100);

                entity.Property(e => e.TargetItems).HasMaxLength(100);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.XpoStateAppearance)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_XpoStateAppearance_State");
            });

            modelBuilder.Entity<XpoStateMachine>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoStateMachine");

                entity.HasIndex(e => e.StartState)
                    .HasName("iStartState_XpoStateMachine");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StatePropertyName).HasMaxLength(100);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);

                entity.HasOne(d => d.StartStateNavigation)
                    .WithMany(p => p.XpoStateMachine)
                    .HasForeignKey(d => d.StartState)
                    .HasConstraintName("FK_XpoStateMachine_StartState");
            });

            modelBuilder.Entity<XpoTrackingRecord>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoTrackingRecord");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ActivityId).HasMaxLength(100);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<XpoTransition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoTransition");

                entity.HasIndex(e => e.SourceState)
                    .HasName("iSourceState_XpoTransition");

                entity.HasIndex(e => e.TargetState)
                    .HasName("iTargetState_XpoTransition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.SourceStateNavigation)
                    .WithMany(p => p.XpoTransitionSourceStateNavigation)
                    .HasForeignKey(d => d.SourceState)
                    .HasConstraintName("FK_XpoTransition_SourceState");

                entity.HasOne(d => d.TargetStateNavigation)
                    .WithMany(p => p.XpoTransitionTargetStateNavigation)
                    .HasForeignKey(d => d.TargetState)
                    .HasConstraintName("FK_XpoTransition_TargetState");
            });

            modelBuilder.Entity<XpoUserActivityVersion>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoUserActivityVersion");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.WorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowDefinition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoWorkflowDefinition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowInstance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoWorkflowInstance");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ExpirationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Owner).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowInstanceControlCommandRequest>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XpoWorkflowInstanceControlCommandRequest");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetWorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpobjectType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPObjectType");

                entity.HasIndex(e => e.TypeName)
                    .HasName("iTypeName_XPObjectType")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.AssemblyName).HasMaxLength(254);

                entity.Property(e => e.TypeName).HasMaxLength(254);
            });

            modelBuilder.Entity<XpweakReference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPWeakReference");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XPWeakReference");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_XPWeakReference");

                entity.HasIndex(e => e.TargetType)
                    .HasName("iTargetType_XPWeakReference");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetKey).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.XpweakReferenceObjectTypeNavigation)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_XPWeakReference_ObjectType");

                entity.HasOne(d => d.TargetTypeNavigation)
                    .WithMany(p => p.XpweakReferenceTargetTypeNavigation)
                    .HasForeignKey(d => d.TargetType)
                    .HasConstraintName("FK_XPWeakReference_TargetType");
            });

            modelBuilder.Entity<XtraReportData>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XtraReportData");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ObjectTypeName).HasMaxLength(512);

                entity.Property(e => e.ParametersObjectTypeName).HasMaxLength(100);

                entity.Property(e => e.PredefinedReportType).HasMaxLength(100);
            });

            modelBuilder.Entity<Yetkilendirme>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Departmanlar)
                    .HasName("idepartmanlar_Yetkilendirme");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Yetkilendirme");

                entity.HasIndex(e => e.Yetkili)
                    .HasName("iyetkili_Yetkilendirme");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Departmanlar).HasColumnName("departmanlar");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ObjectType).HasMaxLength(100);

                entity.Property(e => e.Yetkili).HasColumnName("yetkili");

                entity.HasOne(d => d.DepartmanlarNavigation)
                    .WithMany(p => p.Yetkilendirme)
                    .HasForeignKey(d => d.Departmanlar)
                    .HasConstraintName("FK_Yetkilendirme_departmanlar");

                entity.HasOne(d => d.YetkiliNavigation)
                    .WithMany(p => p.Yetkilendirme)
                    .HasForeignKey(d => d.Yetkili)
                    .HasConstraintName("FK_Yetkilendirme_yetkili");
            });

            modelBuilder.Entity<YonetimKadrosu>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_YonetimKadrosu");

                entity.HasIndex(e => e.Hakkimizda)
                    .HasName("iHakkimizda_YonetimKadrosu");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Görevi).HasMaxLength(100);

                entity.Property(e => e.GöreviEng).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.HakkimizdaNavigation)
                    .WithMany(p => p.YonetimKadrosu)
                    .HasForeignKey(d => d.Hakkimizda)
                    .HasConstraintName("FK_YonetimKadrosu_Hakkimizda");
            });

            modelBuilder.Entity<YoutubeVideo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_YoutubeVideo");

                entity.HasIndex(e => e.VideolarSayfasi)
                    .HasName("ivideolarSayfasi_YoutubeVideo");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Aciklama).HasColumnName("aciklama");

                entity.Property(e => e.EngAciklama).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(100);

                entity.Property(e => e.OlusturanKisi).HasMaxLength(100);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.ResimLinki).HasMaxLength(100);

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.Property(e => e.VideolarSayfasi).HasColumnName("videolarSayfasi");

                entity.HasOne(d => d.VideolarSayfasiNavigation)
                    .WithMany(p => p.YoutubeVideo)
                    .HasForeignKey(d => d.VideolarSayfasi)
                    .HasConstraintName("FK_YoutubeVideo_videolarSayfasi");
            });

            modelBuilder.Entity<Yukseklik>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Yukseklik");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.SonGuncellemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Yuksek).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
