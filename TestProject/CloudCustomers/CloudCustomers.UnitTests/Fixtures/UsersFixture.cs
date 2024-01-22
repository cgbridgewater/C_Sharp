using CloudCustomers.API.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTests.Fixtures {
    public static class UsersFixture {
    public static List<User> GetTestUsers() => new() {
            new User {
                Name = "Owl",
                Email = "Owl@PoohsVille.com",
                Address = new Address {
                    Street = "100 Acre Wood",
                    City = "Poohville",
                    ZipCode = "12345",
                }
            },
            new User {
                Name = "Banks Family",
                Email = "GeorgeBanks@Poppins.com",
                Address = new Address {
                    Street = "17 Cherry Tree Lane",
                    City = "Disney",
                    ZipCode = "90211",
                }
            },
            new User {
                Name = "Doctor Philip Sherman ",
                Email = "DrPhil@FindingNemo.com",
                Address = new Address {
                    Street = "42 Wallaby Way",
                    City = "Sydney",
                    ZipCode = "55555",
                }
            },
            new User {
                Name = "Walt Disney",
                Email = "Walt@TheMouse.com",
                Address = new Address {
                    Street = "500 S. Buena Vista Street",
                    City = "Burbank",
                    ZipCode = "12345",
                }
            },
        };
    }
}
