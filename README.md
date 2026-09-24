# P2P

This is a Visual Studio C# solution that experiments with Windows Peer Name Resolution Protocol (PNRP). NameResolver is a console program that takes a PeerName on the command line, resolves it on the network, and prints comments, data, and IP endpoints (pattern from the MSDN P2P blog). The P2P class library is still an empty stub. It is my working copy from Historical Dev.

**Source last updated:** 2013-09-21  
**Language:** C#  
**Target:** .NET with System.Net.PeerToPeer  
**Output:** Console + empty class library

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `P2P` | C# | Library | Empty `Class1` stub |
| `NameResolver` | C# | Console | PNRP `PeerNameResolver` against argv[0] |
| `Test` | C# | Console | Test host |

## How to open

Open `P2P/P2P.sln` in Visual Studio. PNRP/peer networking must be available on the machine for NameResolver to resolve names.

## Requirements

- Visual Studio 2012, .NET Framework 3.5

## Attribution and provenance

From Dave Robinson's Historical Dev archive (OneDrive folder `P2P`). NameResolver follows the MSDN P2P blog sample for a private PNRP global cloud. Assembly copyright 2013.

## License

MIT License. Copyright (c) 2026 VaderConsulting.
