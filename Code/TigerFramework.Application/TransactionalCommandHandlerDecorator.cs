using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerFramework.Application
{
    public class TransactionalCommandHandlerDecorator<T> : ICommandHandler<T>
    {
        private readonly ICommandHandler<T> _commandHandler;
        public TransactionalCommandHandlerDecorator(ICommandHandler<T> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public void Handle(T command)
        {
            //begin transaction

            _commandHandler.Handle(command);

            //commit transaction
        }
    }
}
