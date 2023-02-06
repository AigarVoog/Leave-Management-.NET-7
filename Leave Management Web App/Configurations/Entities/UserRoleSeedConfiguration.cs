using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leave_Management_Web_App.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "585a7edf-e489-474e-b790-0b8741abc284",
                    UserId = "666a7edf-e489-4abe-b790-0b87ababc284"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "58aa48df-ef80-474e-b790-0b8bce89c284",
                    UserId = "ca293ce2-5d46-4071-907e-211128d0fc28"
                });
        }
    }
}