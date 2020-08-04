﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Infraestructure
{

        public interface IOperation
        {
            Guid OperationId { get; }
        }

        public interface IOperationTransient : IOperation
        {
        }

        public interface IOperationScoped : IOperation
        {
        }

        public interface IOperationSingleton : IOperation
        {
        }

        public interface IOperationSingletonInstance : IOperation
        {
        }
    
}
