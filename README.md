# ServerSwitcher
Allows users to select and join a Server from a list whilst in a server.

**This Plugin now supports [RocketRegions](https://harbor.rocketmod.net/plugins/regions/)**. Thanks to [Trojaner](https://github.com/Trojaner) for allowing me to add this feature and [M22](https://github.com/M22RG) for the idea!

## Configuration
- `RocketRegionsSupport` - When set to true, you can use this plugin with RocketRegions!
- `Servers` - A list of Servers with a custom Name and their IP, Port, Password, Permission and Delay.
  - `Name` - The custom name for the Server that users will use when they do `/server [Server Name]`.
  - `IP` - The IP for the Server. This can be an IPV4 address or a domain name.
  - `Port` - The Port for the Server, such as `27015`.
  - `Password` - The Password for the Server, leave this blank or with any password if the desired Server has no password.
  - `Permission` - The Permission a User has to have to be able to access the Server. See the `Permissions` section below.
  - `Delay` - The Delay, in seconds, before a User is moved to that Server.
  - `CanBeUsedInRocketRegion` - When set to true, this Server can be used in Rocket Regions.
  - `IgnoreDelayInRocketRegion` - When set to true, there will be no delay in switching Servers if it is called from a Rocket Region.
## Commands:
- `/Servers` - Displays a list of Servers in the configuration file. (Shows Name & IP.)
  - Only Servers that a User has permission to join will be displayed.
  
- `/Server [Name]` - Selects a Server to join from the list.
  - The `Name` is the custom name you enter in the configuration.

***RocketRegions Only***
- `/rflag [Region-Name] EnterServerSwitch "URL" -g [GROUP]` - When set, any Players that walk into that Region will be transferred to a different Server. *See [RocketRegions](https://harbor.rocketmod.net/plugins/regions/)* for more information.

## Permissions:
- `serverswitcher.servers` - Users with this permission can execute the `/Servers` command.
- `serverswitcher.server` - Users with this permission can execute the `/Server` command.
- `serverswitcher.server.{SeverPermission}` - Users with this permission can execute the `/Server` command with the selected Servers.
- `serverswitcher.server.*` - Users with this permission can execute the `/Server` command with all Servers.

## Demonstration:
https://www.youtube.com/watch?v=yQFYHYOUL1U
 
