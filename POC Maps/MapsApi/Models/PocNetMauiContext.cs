using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MapsApi.Models;

public partial class PocNetMauiContext : DbContext
{
    public PocNetMauiContext()
    {
    }

    public PocNetMauiContext(DbContextOptions<PocNetMauiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alertum> Alerta { get; set; }

    public virtual DbSet<Cadastro> Cadastros { get; set; }

    public virtual DbSet<CadastroCidade> CadastroCidades { get; set; }

    public virtual DbSet<CadastroEstado> CadastroEstados { get; set; }

    public virtual DbSet<CadastroPai> CadastroPais { get; set; }

    public virtual DbSet<Chamado> Chamados { get; set; }

    public virtual DbSet<Historico> Historicos { get; set; }

    public virtual DbSet<TelaLogin> TelaLogins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=POC_NET_MAUI;Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alertum>(entity =>
        {
            entity.HasKey(e => e.AlertaId).HasName("PK__Alerta__D9EF47E5CFDD1451");

            entity.Property(e => e.AlertaId)
                .ValueGeneratedNever()
                .HasColumnName("AlertaID");
            entity.Property(e => e.Cancelar).HasColumnName("cancelar");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cadastro>(entity =>
        {
            entity.HasKey(e => e.CadastroId).HasName("PK__Cadastro__4D55D2D42B1F6ADD");

            entity.ToTable("Cadastro");

            entity.Property(e => e.CadastroId)
                .ValueGeneratedNever()
                .HasColumnName("CadastroID");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bairro");
            entity.Property(e => e.CadastroCidadeId).HasColumnName("Cadastro_CidadeID");
            entity.Property(e => e.CadastroEstadoId).HasColumnName("Cadastro_EstadoID");
            entity.Property(e => e.CadastroPaisId).HasColumnName("Cadastro_PaisID");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("complemento");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumCasa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_casa");
            entity.Property(e => e.NumOab).HasColumnName("Num_OAB");
            entity.Property(e => e.Rua)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rua");
            entity.Property(e => e.Senha)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("senha");
            entity.Property(e => e.SenhaAdministrador)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("senha_administrador");

            entity.HasOne(d => d.CadastroCidade).WithMany(p => p.Cadastros)
                .HasForeignKey(d => d.CadastroCidadeId)
                .HasConstraintName("FK__Cadastro__Cadast__2B3F6F97");

            entity.HasOne(d => d.CadastroEstado).WithMany(p => p.Cadastros)
                .HasForeignKey(d => d.CadastroEstadoId)
                .HasConstraintName("FK__Cadastro__Cadast__2C3393D0");

            entity.HasOne(d => d.CadastroPais).WithMany(p => p.Cadastros)
                .HasForeignKey(d => d.CadastroPaisId)
                .HasConstraintName("FK__Cadastro__Cadast__2A4B4B5E");
        });

        modelBuilder.Entity<CadastroCidade>(entity =>
        {
            entity.HasKey(e => e.CadastroCidadeId).HasName("PK__Cadastro__1026196F8BE4E144");

            entity.ToTable("Cadastro_Cidade");

            entity.Property(e => e.CadastroCidadeId)
                .ValueGeneratedNever()
                .HasColumnName("Cadastro_CidadeID");
            entity.Property(e => e.NomeCidade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nome_Cidade");
        });

        modelBuilder.Entity<CadastroEstado>(entity =>
        {
            entity.HasKey(e => e.CadastroEstadoId).HasName("PK__Cadastro__37EB42E4C7BBB3E5");

            entity.ToTable("Cadastro_Estado");

            entity.Property(e => e.CadastroEstadoId)
                .ValueGeneratedNever()
                .HasColumnName("Cadastro_EstadoID");
            entity.Property(e => e.NomeEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nome_Estado");
        });

        modelBuilder.Entity<CadastroPai>(entity =>
        {
            entity.HasKey(e => e.CadastroPaisId).HasName("PK__Cadastro__07A46D1E6A270C01");

            entity.ToTable("Cadastro_Pais");

            entity.Property(e => e.CadastroPaisId)
                .ValueGeneratedNever()
                .HasColumnName("Cadastro_PaisID");
            entity.Property(e => e.NomePais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nome_Pais");
        });

        modelBuilder.Entity<Chamado>(entity =>
        {
            entity.HasKey(e => e.ChamadosId).HasName("PK__Chamados__51D4CED56DA28377");

            entity.Property(e => e.ChamadosId)
                .ValueGeneratedNever()
                .HasColumnName("ChamadosID");
            entity.Property(e => e.AlertaId).HasColumnName("AlertaID");
            entity.Property(e => e.CadastroId).HasColumnName("CadastroID");
            entity.Property(e => e.DataHora)
                .HasColumnType("datetime")
                .HasColumnName("Data_Hora");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Alerta).WithMany(p => p.Chamados)
                .HasForeignKey(d => d.AlertaId)
                .HasConstraintName("FK__Chamados__Alerta__31EC6D26");

            entity.HasOne(d => d.Cadastro).WithMany(p => p.Chamados)
                .HasForeignKey(d => d.CadastroId)
                .HasConstraintName("FK__Chamados__Cadast__30F848ED");
        });

        modelBuilder.Entity<Historico>(entity =>
        {
            entity.HasKey(e => e.HistoricoId).HasName("PK__Historic__4A561D76E298142B");

            entity.ToTable("Historico");

            entity.Property(e => e.HistoricoId)
                .ValueGeneratedNever()
                .HasColumnName("HistoricoID");
            entity.Property(e => e.AlertaId).HasColumnName("AlertaID");
            entity.Property(e => e.CadastroId).HasColumnName("CadastroID");
            entity.Property(e => e.DataHoraCancelamento)
                .HasColumnType("datetime")
                .HasColumnName("Data_Hora_Cancelamento");

            entity.HasOne(d => d.Alerta).WithMany(p => p.Historicos)
                .HasForeignKey(d => d.AlertaId)
                .HasConstraintName("FK__Historico__Alert__35BCFE0A");

            entity.HasOne(d => d.Cadastro).WithMany(p => p.Historicos)
                .HasForeignKey(d => d.CadastroId)
                .HasConstraintName("FK__Historico__Cadas__34C8D9D1");
        });

        modelBuilder.Entity<TelaLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tela_Login");

            entity.Property(e => e.CadastroId).HasColumnName("CadastroID");

            entity.HasOne(d => d.Cadastro).WithMany()
                .HasForeignKey(d => d.CadastroId)
                .HasConstraintName("FK__Tela_Logi__Cadas__37A5467C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
