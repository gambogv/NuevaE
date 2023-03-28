using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Antioquia",
                            Cities = new List<City>() {
                                new City() { Name = "Medellín" },
                                new City() { Name = "Itagüí" },
                                new City() { Name = "Envigado" },
                                new City() { Name = "Bello" },
                                new City() { Name = "Rionegro" },
                            }
                        },
                        new State()
                        {
                            Name = "Bogotá",
                            Cities = new List<City>() {
                                new City() { Name = "Usaquen" },
                                new City() { Name = "Champinero" },
                                new City() { Name = "Santa fe" },
                                new City() { Name = "Useme" },
                                new City() { Name = "Bosa" },
                            }
                        },
                    }
                });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Florida",
                            Cities = new List<City>() {
                                new City() { Name = "Orlando" },
                                new City() { Name = "Miami" },
                                new City() { Name = "Tampa" },
                                new City() { Name = "Fort Lauderdale" },
                                new City() { Name = "Key West" },
                            }
                        },
                        new State()
                        {
                            Name = "Texas",
                            Cities = new List<City>() {
                                new City() { Name = "Houston" },
                                new City() { Name = "San Antonio" },
                                new City() { Name = "Dallas" },
                                new City() { Name = "Austin" },
                                new City() { Name = "El Paso" },
                            }
                        },
                    }
                });

                await _context.SaveChangesAsync();
            }

            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category
                {
                    Name = "Automotores",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Repuestos",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "LLantas" },
                                new ProdCategory() { Name = "Bacreria" },
                                new ProdCategory() { Name = "Cogineria" },
                                new ProdCategory() { Name = "Luces" },
                                new ProdCategory() { Name = "Cables" },
                            }
                        },
                        new Product()
                        {
                            Name = "Pintura",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "Tipo 1" },
                                new ProdCategory() { Name = "Tipo 2 A" },
                                new ProdCategory() { Name = "Tipo 2" },
                                new ProdCategory() { Name = "Tipo 3" },
                                new ProdCategory() { Name = "Tipo 3 A" },
                            }
                        },
                    }
                });

                _context.Categories.Add(new Category
                {
                    Name = "Tecnologia",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Sonido",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "Bafles" },
                                new ProdCategory() { Name = "Bajos" },
                                new ProdCategory() { Name = "Twuiters" },
                                new ProdCategory() { Name = "Pantalla" },
                                new ProdCategory() { Name = "Wopers" },
                            }
                        },
                        new Product()
                        {
                            Name = "Electrico",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "Vidrios 1" },
                                new ProdCategory() { Name = "Alarma 2 A" },
                                new ProdCategory() { Name = "Sensores 2" },
                                new ProdCategory() { Name = "Sillas 3" },
                                new ProdCategory() { Name = "Parabrisas 3 A" },
                            }
                        },
                    }
                });

                _context.Categories.Add(new Category
                {
                    Name = "Casa",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Remodelacion",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "Pintura" },
                                new ProdCategory() { Name = "Enchapes" },
                                new ProdCategory() { Name = "Baños" },
                                new ProdCategory() { Name = "Electricidad" },
                                new ProdCategory() { Name = "Acueducto" },
                            }
                        },
                        new Product()
                        {
                            Name = "Interior",
                            prodCategories = new List<ProdCategory>() {
                                new ProdCategory() { Name = "Juego de sala" },
                                new ProdCategory() { Name = "Alcoba" },
                                new ProdCategory() { Name = "Cocina" },
                                new ProdCategory() { Name = "Patio" },
                                new ProdCategory() { Name = "Puertas" },
                            }
                        },
                    }
                });

                await _context.SaveChangesAsync();


            }
        }
    }
}