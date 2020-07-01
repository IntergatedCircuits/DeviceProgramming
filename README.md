# DeviceProgramming
Standalone C# library for device firmware programming

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

## Features
This is a standalone C# library that implements
* Generic classes for device firmware and memory layout representation (`DeviceProgramming.Memory`)
* Parsers for common firmware image file formats such as Intel HEX and Motorola SREC (`DeviceProgramming.FileFormats`)
* USB DFU class logic (`DeviceProgramming.Dfu`) and file parser (`DeviceProgramming.FileFormats.Dfu`)
supporting both the latest official USB specification (version 1.1) and the ST Microelectronics Extension (version 1.1a)
