﻿using PTSSRU.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTSSRU.Datas
{ 
    public static class Palace
{
    public static IList<Ismodel> P { get; private set; }

    static Palace()
    {
        P = new List<Ismodel>();

        P.Add(new Ismodel
        {
            Name = "อาทรทิพยนิวาสน์",
            Location = "Africa & Asia",
            Details = "ooooooo",
            ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpjqk.jpg",
        });

        P.Add(new Ismodel
        {
            Name = "อาทรทิพยนิวาสน์2",
            Location = "Central & South America",
            Details = "a",
            ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpl8v.jpg"
        });
        
         P.Add(new Ismodel
        {
            Name = "อาคารจุฑารัตนาภรณ์",
            Location = "Central & South America",
            Details = "a",
            ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpD7E.jpg"
         });
            P.Add(new Ismodel
            {
                Name = "กำลังซ่อม",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpuln.jpg"
            });

            P.Add(new Ismodel
            {
                Name = "อาคารศศิพงษ์ประไพ",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpCtS.jpg"
            });

            P.Add(new Ismodel
            {
                Name = "ศาลปราสาทสมเด็จพระนางเจ้าสวนสุนันทากุมารีรัตน์",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKp6Gg.jpg"
            });

            P.Add(new Ismodel
            {
                Name = "อาคารสายสุรธานภดล",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpP2V.jpg"
            });

            P.Add(new Ismodel
            {
                Name = "โบราณสถาน หลุมหลบภัย เนินพระนาง",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpAgN.jpg"
            });

            P.Add(new Ismodel
            {
                Name = "อนุสาวรีย์ พระองค์เจ้าสุนันทากุมารีรัตน์",
                Location = "Africa & Asia",
                Details = "ooooooo",
                ImageUrl = "https://sv1.picz.in.th/images/2021/01/11/lKpsFQ.jpg"
            });         
        }
}
}
