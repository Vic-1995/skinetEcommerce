using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        private Func<Product, bool> p;

        public BaseSpecification()
        {
        }

        public BaseSpecification(Func<Product, bool> p)
        {
            this.p = p;
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria, List<Expression<Func<T, object>>> includes)
        {
            Criteria = criteria;
            Includes = includes;
        }

        public Expression<Func<T, bool>> Criteria {get; } 
        public List<Expression<Func<T, object>>> Includes {get; } = 
        new List<Expression<Func<T, object>>>();

       protected void AddInclude(Expression<Func<T, object>> includeExpression)
       {
           Includes.Add(includeExpression);
       }
    }
}