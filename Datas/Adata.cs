using PTSSRU.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTSSRU.Datas
{
    public static class Adata
    {
        public static IList<Ismodel> AA { get; private set; }

        static Adata()
        {
            AA = new List<Ismodel>();

            AA.Add(new Ismodel
            {
                Name = "Baboon",
                Location = "13.776692280120338,100.50902230906989",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            AA.Add(new Ismodel
            {
                Name = "Capuchin Monkey",
                Location = "13.776692280120338,100.50902230906989",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });
        }
    }
}
