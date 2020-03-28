    Ideally I would like to clarify requirements before writing code. For example, I would check the range of supported characters
    (ASCII, extended ASCII or Unicode). I would also check what characters can be considered to be a part of a word.

    I would also clarify requirements for treatment of nulls, empty strings and strings without words. 

    I would also double-check why the function should return both word and its length. It is very unusual because in C# it is trivial
    to get the length of a string (by calling .Length getter). It would be natural if the function only returned a string (the longest word). 

    I would also look at coding standards in the system, any external systems which use the results of this method,
    and discuss it with the colleagues.
    
    It is a coding test and (I assume) it is not possible to clarify the requirements. Therefore I have made a number of assumptions.

    - All Unicode symbols are supported
    - Words can only consist of letters defined by C# char.IsLetter function.
        (Note that as a consequence, HTML5 and King's would not be considered words)
    - If an argument is null, the function should throw an exception
    - If an argument is an empty string, the function should return null and 0
    - If an argument is a string without letters, the function should return null and 0
    - I assume that there are requirements which explain why the function must return both the word and its length
    - I assume that if there two equally long words, the function can return any of them 
    - I assume that function will be used with strings of reasonable length (eg thousands, not millions, of characters)
    - I assume that that low-level performance optimisation is not needed

    |The code and the tests are implemented in C#, .NET Standard 2.0.
    They can be built and executed using Visual Studio (https://visualstudio.microsoft.com/).
    
    Alternatively they can be built and executed using .NET Core CLI included in .NET Core SDK (https://docs.microsoft.com/en-us/dotnet/core/install/sdk?pivots=os-windows)
    - Open solution folder in a command prompt
    - Execute 'dotnet build' command
    - Execute 'dotnet test' command
