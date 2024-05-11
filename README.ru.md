# UFT
UFT — Universal File Template / Универсальный файловый шаблон  
UFT позволяет создавать файлы по шаблонам.
## Написание шаблона
```xml
<output extension=".txt">
Hello, World!
</output>
```
Можно получить имя файла который будет использовать этот шаблон так:
```xml
<output extension=".txt">
File name is: <name>
</output>
```
А также можно получить его путь:
```xml
<output extension=".txt">
Path: <path>
</output>
```
Ещё можно изменить имя файла:
```xml
<output name="Other Name" extension=".cs">
something...
</output>
```
### Практический пример
```xml
<!-- Мы сделаем шаблон для создания интерфейса для языка програмирования C#-->
<output name="I<name>" extension=".cs">
namespace MyCSharpProject;

public interface I<name>
{
    
}
</output>
```
