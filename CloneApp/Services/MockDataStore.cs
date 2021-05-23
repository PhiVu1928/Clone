using CloneApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CloneApp.Services
{
    public class MockDataStore
    {
        public ObservableCollection<ShoesItems> Items { get; set; }
        public MockDataStore()
        {
            Items = Getshoes();
        }
        public ObservableCollection<ShoesItems> Getshoes()
        {
            Items = new ObservableCollection<ShoesItems>()
            {
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "dd0587 600" , Colorway = " varsity red/black/white", Name = "AIR JORDAN 5 RETRO 'RAGING BULL' 2021", Price = 222.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/254938/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 2, Style = "554724 074", Colorway = "black/university red/black/white",Name = "AIR JORDAN 1 MID 'BANNED'", Price = 200.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/245237/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 3, Style = "555088 118", Colorway = "white/volt/university gold/black",Name = "AIR JORDAN 1 RETRO HIGH OG 'VOLT GOLD'", Price = 210.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/173899/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 4, Style = "cd4487 100", Colorway = "sail/dark mocha-university red-black",Name = "TRAVIS SCOTT X AIR JORDAN 1 RETRO HIGH OG 'MOCHA'", Price = 1300.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/806920/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 5, Style = "aq0818 148", Colorway = "white/dark powder blue-cone",Name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", Price = 1750.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/804093/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "555088 001", Colorway = "black/varsity red-white",Name = "AIR JORDAN 1 RETRO HIGH OG 'BANNED' 2016", Price = 400.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/012496/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "dd0587 600" , Colorway = " varsity red/black/white", Name = "AIR JORDAN 5 RETRO 'RAGING BULL' 2021", Price = 222.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/254938/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 2, Style = "554724 074", Colorway = "black/university red/black/white",Name = "AIR JORDAN 1 MID 'BANNED'", Price = 200.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/245237/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 3, Style = "555088 118", Colorway = "white/volt/university gold/black",Name = "AIR JORDAN 1 RETRO HIGH OG 'VOLT GOLD'", Price = 210.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/173899/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 4, Style = "cd4487 100", Colorway = "sail/dark mocha-university red-black",Name = "TRAVIS SCOTT X AIR JORDAN 1 RETRO HIGH OG 'MOCHA'", Price = 1300.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/806920/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 5, Style = "aq0818 148", Colorway = "white/dark powder blue-cone",Name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", Price = 1750.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/804093/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "555088 001", Colorway = "black/varsity red-white",Name = "AIR JORDAN 1 RETRO HIGH OG 'BANNED' 2016", Price = 400.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/012496/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "dd0587 600" , Colorway = " varsity red/black/white", Name = "AIR JORDAN 5 RETRO 'RAGING BULL' 2021", Price = 222.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/254938/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 2, Style = "554724 074", Colorway = "black/university red/black/white",Name = "AIR JORDAN 1 MID 'BANNED'", Price = 200.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/245237/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 3, Style = "555088 118", Colorway = "white/volt/university gold/black",Name = "AIR JORDAN 1 RETRO HIGH OG 'VOLT GOLD'", Price = 210.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/173899/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 4, Style = "cd4487 100", Colorway = "sail/dark mocha-university red-black",Name = "TRAVIS SCOTT X AIR JORDAN 1 RETRO HIGH OG 'MOCHA'", Price = 1300.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/806920/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 5, Style = "aq0818 148", Colorway = "white/dark powder blue-cone",Name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", Price = 1750.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/804093/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "555088 001", Colorway = "black/varsity red-white",Name = "AIR JORDAN 1 RETRO HIGH OG 'BANNED' 2016", Price = 400.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/012496/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "dd0587 600" , Colorway = " varsity red/black/white", Name = "AIR JORDAN 5 RETRO 'RAGING BULL' 2021", Price = 222.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/254938/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 2, Style = "554724 074", Colorway = "black/university red/black/white",Name = "AIR JORDAN 1 MID 'BANNED'", Price = 200.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/245237/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 3, Style = "555088 118", Colorway = "white/volt/university gold/black",Name = "AIR JORDAN 1 RETRO HIGH OG 'VOLT GOLD'", Price = 210.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/173899/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 4, Style = "cd4487 100", Colorway = "sail/dark mocha-university red-black",Name = "TRAVIS SCOTT X AIR JORDAN 1 RETRO HIGH OG 'MOCHA'", Price = 1300.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/806920/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 5, Style = "aq0818 148", Colorway = "white/dark powder blue-cone",Name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", Price = 1750.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/804093/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "555088 001", Colorway = "black/varsity red-white",Name = "AIR JORDAN 1 RETRO HIGH OG 'BANNED' 2016", Price = 400.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/012496/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "dd0587 600" , Colorway = " varsity red/black/white", Name = "AIR JORDAN 5 RETRO 'RAGING BULL' 2021", Price = 222.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/254938/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 2, Style = "554724 074", Colorway = "black/university red/black/white",Name = "AIR JORDAN 1 MID 'BANNED'", Price = 200.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/245237/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 3, Style = "555088 118", Colorway = "white/volt/university gold/black",Name = "AIR JORDAN 1 RETRO HIGH OG 'VOLT GOLD'", Price = 210.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/173899/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 4, Style = "cd4487 100", Colorway = "sail/dark mocha-university red-black",Name = "TRAVIS SCOTT X AIR JORDAN 1 RETRO HIGH OG 'MOCHA'", Price = 1300.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/806920/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 5, Style = "aq0818 148", Colorway = "white/dark powder blue-cone",Name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", Price = 1750.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/804093/1.jpg" },
                new ShoesItems { Id = Guid.NewGuid().ToString(), CateID = 1, Style = "555088 001", Colorway = "black/varsity red-white",Name = "AIR JORDAN 1 RETRO HIGH OG 'BANNED' 2016", Price = 400.00f, Image = "https://cdn.flightclub.com/1500/TEMPLATE/012496/1.jpg" },
            };
            return Items;
        }
        
    }
}