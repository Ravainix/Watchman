﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchman.Cqrs;
using Watchman.Integrations.MongoDB;

namespace Watchman.DomainModel.ServerPrefixes.Commands.Handlers
{
    public class AddPrefixCommandHandler : ICommandHandler<AddPrefixCommand>
    {
        private readonly ISessionFactory _sessionFactory;

        public AddPrefixCommandHandler(ISessionFactory sessionFactory)
        {
            this._sessionFactory = sessionFactory;
        }

        public async Task HandleAsync(AddPrefixCommand command)
        {
            using var session = this._sessionFactory.Create();
            var prefix = new ServerPrefixes(command.ServerId, command.Value);
            await session.AddAsync(prefix);
        }
    }
}
