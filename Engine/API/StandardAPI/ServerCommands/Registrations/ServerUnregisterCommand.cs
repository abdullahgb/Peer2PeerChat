﻿using Engine.Model.Server;

namespace Engine.API.StandardAPI.ServerCommands
{
  class ServerUnregisterCommand : IServerAPICommand
  {
    public void Run(ServerCommandArgs args)
    {
      ServerModel.API.CloseConnection(args.ConnectionId);
    }

    public const ushort Id = (ushort)ServerCommand.Unregister;
  }
}
