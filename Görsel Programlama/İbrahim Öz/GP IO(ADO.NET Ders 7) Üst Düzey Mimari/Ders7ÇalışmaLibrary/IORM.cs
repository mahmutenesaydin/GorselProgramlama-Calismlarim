﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ÇalışmaLibrary
{
    public interface IORM<T>
    {
        DataTable Listele();
        bool Ekle(T entity);
        bool Guncelle(T entity);
        bool Sil(int ID);
    }
}
