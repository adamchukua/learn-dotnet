# Контрольні питання

<ul>
  <li><a href="#lab1">Лабораторна робота 1</a></li>
  <li><a href="#lab2">Лабораторна робота 2</a></li>
</ul>

<div id="lab1">
  <h2>Лабораторна робота 1</h2>
  
  <ol>
    <li>1.	Які мови програмування підтримує CLR?<br>
    Можливо реалізувати підпрограми CLR на будь-якій мові, яка може бути скомпільована в збірку IL. Наприклад: C++, C#, Visual Basic і J#.</li>
    <li>2.	З яких компонентів складається CLR?<br>
      Основними компонентами CLR є:
      <ol>
        <li>Common type system</li>
        <li>Common language speciation</li>
        <li>Garbage Collector</li>
        <li>Just in Time Compiler</li>
        <li>Metadata and Assemblies</li>
      </ol></li>
    <li>3.	Скільки рівнів має Garbage Collector?<br>
  Рівень 0 ідентифікує щойно створений об’єкт, який ніколи не позначався для збирання. Рівень 1 ідентифікує об’єкт, який витримав GC (позначено для збирання, але не видалено, оскільки було достатньо місця у купі). Рівень 2 ідентифікує об’єкт, який витримав більше одного циклу GC.</li>
    <li>4.	Коли викликається останній рівень GC?<br>
  Коли не вистачає пам'яті і 2 попередніх рівні вже пройшли.</li>
    <li>5.	Що таке CLS?<br>
  Щоб увімкнути сценарії повної взаємодії, усі об’єкти, створені в коді, мають покладатися на певну спільність у мовах, які їх використовують (є їхніми викликами). Оскільки існує велика кількість різних мов, .NET визначила ці спільні риси у так званій специфікації загальної мови (CLS). CLS визначає набір функцій, необхідних багатьом поширеним програмам. Він також надає свого роду рецепт для будь-якої мови, яка реалізована поверх .NET, щодо того, що вона повинна підтримувати.</li>
  </ol>
</div>

<div id="lab2">
  <h2>Лабораторна робота 2</h2>
  
  1.	Які базові бібліотеки використовувались для .NET Framework, .NET Core та Xamarin?
2.	Що таке .NET Standard?
3.	Скільки існує видів бібліотек і які?
4.	Для чого використовується Mono class libraries?
5.	Яка бібліотека містить фундаментальні та базові класи?
</div>
