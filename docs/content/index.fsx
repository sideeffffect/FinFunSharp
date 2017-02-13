(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
FinFunSharp
======================

Documentation

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The FinFunSharp library can be <a href="https://nuget.org/packages/FinFunSharp">installed from NuGet</a>:
      <pre>PM> Install-Package FinFunSharp</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Example
-------

This example demonstrates using a function defined in this sample library.

*)
#r "FinFunSharp.dll"
open FinFunSharp

printfn "hello = %i" <| Library.hello 0

(**
Some more info

Samples & documentation
-----------------------

The library comes with comprehensible documentation. 
It can include tutorials automatically generated from `*.fsx` files in [the content folder][content]. 
The API reference is automatically generated from Markdown comments in the library implementation.

 * [Tutorial](tutorial.html) contains a further explanation of this sample library.

 * [API Reference](reference/index.html) contains automatically generated documentation for all types, modules
   and functions in the library. This includes additional brief samples on using most of the
   functions.
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

FinFunSharp Financial playground in F#
Copyright (C) 2017  Ondrej Pelech

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

For more information see the [License file][license] in the GitHub repository. 

  [content]: https://github.com/sideeffffect/FinFunSharp/tree/master/docs/content
  [gh]: https://github.com/sideeffffect/FinFunSharp
  [issues]: https://github.com/sideeffffect/FinFunSharp/issues
  [readme]: https://github.com/sideeffffect/FinFunSharp/blob/master/README.md
  [license]: https://github.com/sideeffffect/FinFunSharp/blob/master/LICENSE.txt
*)
