﻿using Microsoft.EntityFrameworkCore.Query;
using OnionAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : class, IBaseEntity, new()
    {

        //Tüm ögeleri asenkron olarak alır.Filtreleme, dahil etme, sıralama izleme seçenekleri sunar.

        Task <IList<T>>GetAllAsync(Expression<Func<T,bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);
        //Sayfalama desteği ile tüm ögeleri asenkron olarak alır.Filtreleme, dahil etme, sıralama izleme seçenekleri sunar.Sayfa numarası ve sayfa boyutu parametreleri eklenmiştir.
        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false, int currentPage = 1, int pageSize = 3);


        //Belirli bir kriteri karşılayan tek bir ögeyi asenkron olarak alır.
        Task<T> GetAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);

        //Belirli bir kriteri karşılayan ögeyi sorgular.
        IQueryable<T> Find(Expression<Func<T, bool>>? predicate = null,
            bool enableTracking = false);

        //Belirli bir kriteri karşılayan ögenin sayısını asenkron olarak alır.
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }
}
