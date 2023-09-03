using CourseAPI.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseAPI.Infrastructure.Data.Mappings
{
    public class CursoMapping: IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("TB_CURSO");
            builder.HasKey(p => p.Codigo)
        }
    }
}
