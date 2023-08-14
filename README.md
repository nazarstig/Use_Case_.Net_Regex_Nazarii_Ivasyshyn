# Use_Case_.Net_Regex_Nazarii_Ivasyshyn

## Application description
Checks if input expression matches criterias: 
- should be not empty;
- should be not longer that length (passed as parameter);
- should contain at least one uppercase letter;
- should contain at least one lowercase letter;
- should contain at least one digit;
- should contain at least one special character (!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~);
- should NOT contain any whitespace characters (spaces, tabs, or newlines);

## Regex implementation
So, at first program checks if the string is not empty and 
if has appropriate length. Not to make one complicated regex,
I divided it on two: at first it checks if there is any whitespace symbol,
and then checks if string contains all required symbols. If yes - then 
function returns true, if not - return false.

### How to run locally
In Visual Studio: Open Solution with test project -> 
Build -> Build solution.
After that in folder \bin\Debug pr will be created
file =Use_Case_.Net_Regex_Nazarii_Ivasyshyn.dll=.
After that we can take that file and add functionality
to any project, for example console app.
More detailed instruction is here: https://www.codementor.io/@dewetvanthomas/tutorial-class-library-dll-for-c-129spithmr
To check if string is valid, we will have just to call
method =Matches(string input, int maxLength)= of static
class =RegexImplementation=.
Example: =RegexInplementation.Matches("Test", 12)=.