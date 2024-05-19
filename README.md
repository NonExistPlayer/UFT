# UFT
UFT — Universal File Template.  
UFT allows you to create files using templates.
## Writing a template
```xml
<output extension=".txt">
Hello, World!
</output>
```
You can get the name of the file that will use this template like this:
```xml
<output extension=".txt">
File name is: <name>
</output>
```
You can also get its path:
```xml
<output extension=".txt">
Path: <path>
</output>
```
You can also change the file name:
```xml
<output name="Other Name" extension=".cs">
something...
</output>
```
### Case Study
```xml
<!-- I will make a template for creating an interface for the C# programming language-->
<output name="I<name>" extension=".cs">
namespace MyCSharpProject;

public interface I<name>
{
    
}
</output>
```
