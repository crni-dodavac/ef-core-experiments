using Entitties.Domain.UserContext;
using Microsoft.EntityFrameworkCore;

namespace Entitties.Database.DatabaseDefinitions;

public static class UserDefinitions
{
    public const string PrimaryKey = "UserId";

    public static ModelBuilder DefineUserModel(this ModelBuilder builder)
    {
        builder.Entity<User>(userModelBuilder =>
        {
            userModelBuilder
                .Property<long>(PrimaryKey);

            userModelBuilder
                .HasKey(PrimaryKey);

            userModelBuilder
                .Property(u => u.Id)
                .HasConversion(
                    domainClrType => domainClrType.ToString(),
                    dbClrType => new UserId(dbClrType))
                .HasColumnName("Reference");

            userModelBuilder
                .HasIndex(u => u.Id)
                .IsUnique();
        });

        return builder;
    }
}