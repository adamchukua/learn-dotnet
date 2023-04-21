# Контрольні питання
<ul>
  <li>
    <a href="#lab1">Лабораторна робота 1</a>
  </li>
  <li>
    <a href="#lab2">Лабораторна робота 2</a>
  </li>
  <li>
    <a href="#lab3">Лабораторна робота 3</a>
  </li>
  <li>
    <a href="#lab4">Лабораторна робота 4</a>
  </li>
  <li>
    <a href="#lab5">Лабораторна робота 5</a>
  </li>
  
  <li>
    <a href="#lab6">Лабораторна робота 6</a>
  </li>
  
  <li>
    <a href="#lab7">Лабораторна робота 7</a>
  </li>
  
  <li>
    <a href="#lab8">Лабораторна робота 8</a>
  </li>
</ul>
<div id="lab1">
  <h2>Лабораторна робота 1</h2>
  <ol>
    <li>Які мови програмування підтримує CLR? <br> Можливо реалізувати підпрограми CLR на будь-якій мові, яка може бути скомпільована в збірку IL. Наприклад: C++, C#, Visual Basic і J#. </li>
    <li>З яких компонентів складається CLR? <br> Основними компонентами CLR є: <ol>
        <li>Common type system</li>
        <li>Common language speciation</li>
        <li>Garbage Collector</li>
        <li>Just in Time Compiler</li>
        <li>Metadata and Assemblies</li>
      </ol>
    </li>
    <li>Скільки рівнів має Garbage Collector? <br> Рівень 0 ідентифікує щойно створений об’єкт, який ніколи не позначався для збирання. Рівень 1 ідентифікує об’єкт, який витримав GC (позначено для збирання, але не видалено, оскільки було достатньо місця у купі). Рівень 2 ідентифікує об’єкт, який витримав більше одного циклу GC. </li>
    <li>Коли викликається останній рівень GC? <br> Коли не вистачає пам'яті і 2 попередніх рівні вже пройшли. </li>
    <li>Що таке CLS? <br> Щоб увімкнути сценарії повної взаємодії, усі об’єкти, створені в коді, мають покладатися на певну спільність у мовах, які їх використовують (є їхніми викликами). Оскільки існує велика кількість різних мов, .NET визначила ці спільні риси у так званій специфікації загальної мови (CLS). CLS визначає набір функцій, необхідних багатьом поширеним програмам. Він також надає свого роду рецепт для будь-якої мови, яка реалізована поверх .NET, щодо того, що вона повинна підтримувати. </li>
  </ol>
</div>
<div id="lab2">
  <h2>Лабораторна робота 2</h2>
  <ol>
    <li>Які базові бібліотеки використовувались для .NET Framework, .NET Core та Xamarin? <br> Ті, які містяться в .NET Standard. </li>
    <li>Що таке .NET Standard? <br> .NET Standard – це набір API, доступний на всіх. Реалізації NET створять певний тип уніфікованості, переносимості, яка підтримує Net Core, Xamarin і .Net Framework. По суті, це набір бібліотек базових класів (BCL), які підтримують широкий спектр технологій. </li>
    <li>Скільки існує видів бібліотек і які? <br>
      <ul>
        <li>Platform-specific class libraries</li>
        <li>Portable class libraries</li>
        <li>.NET Standard class libraries</li>
        <li>Mono class libraries</li>
      </ul>
    </li>
    <li>Для чого використовується Mono class libraries? <br> Mono часто розглядається як кросплатформна реалізація .NET Framework. Частково це пояснюється тим, що бібліотеки .NET Framework для певної платформи можуть працювати у середовищі виконання Mono без модифікації чи повторної компіляції. Ця характеристика існувала до створення портативних бібліотек класів, тому було очевидним вибором увімкнути бінарну переносимість між .NET Framework і Mono (хоча це працювало лише в одному напрямку). </li>
    <li>Яка бібліотека містить фундаментальні та базові класи? <br> .NET Standard </li>
  </ol>
</div>
<div id="lab3">
  <h2>Лабораторна робота 3</h2>
  <ol>
    <li>У чому відмінність асинхронного і багатопоточного програмування? <br>Асинхронне програмування це парадигма програмування, в якій процеси адресуються багатьма паралельно за допомогою засобів синхронізації та зв'язків. Це дозволяє програмі завантажувати відтак від послідовності кроків. Багатопоточне програмування використовує один або декілька потоків виконання для адресації декількох завдань за допомогою одного або двох процесів. </li>
    <li>Які типи даних може повертати async – await? <br>Task, Task <T> void, IAsyncEnumerable <T>
    </li>
    <li>Які модифікатори для параметрів не можна використовувати в асинхронних методах? <br>ref, out, params </li>
    <li>Які властивості надає клас Thread? Опишіть їх. <br>Клас Thread надає властивості, такі як обслуговування часу, призупинення, продовження, переривання. В мові програмування C# клас Thread також надає методи для завантаження або ініціалізації потоку, отримання стану потоку, порівняння двох потоків. </li>
    <li>Які методи надає клас Thread? Опишіть їх. <br>Abort() використовується для завершення потоку. Interrupt() використовується для переривання потоку, який знаходиться в стані WaitSleepJoin. Join() використовується для блокування всіх викликаючих потоків, доки цей потік не завершиться. ResetAbort() використовується для скасування запиту Abort для поточного потоку. Sleep() використовується для призупинення поточного потоку на вказані мілісекунди. Start() змінює поточний стан потоку на Runnable. </li>
  </ol>
</div>
<div id="lab4">
  <h2>Лабораторна робота 4</h2>
  <ol>
    <li>Що таке рефлексія? <br>Рефлексія - це механізм, що дозволяє отримувати інформацію про типи, класи, інтерфейси, атрибути та інші елементи програми виконання .NET, а також взаємодіяти з ними за допомогою коду. </li>
    <li>Для чого використовується Reflection? <br>Reflection використовується для взаємодії з типами та об'єктами під час виконання програми. Це дозволяє динамічно створювати об'єкти, викликати методи, встановлювати та отримувати значення властивостей та поля, робити інші операції, що були визначені під час компіляції. </li>
    <li>Чи можна працювати за допомогою Reflection з компілюваними збірками? <br>Так, можна. Reflection дозволяє отримувати інформацію про класи та інші елементи збірки навіть якщо вона була скомпільована до DLL або EXE файлу. </li>
    <li>Який namespace у Reflection? <br>Namespace для Reflection - System.Reflection. </li>
    <li>Якщо збірка містить поле/метод з модифікатором доступу private, чи маємо ми можливість працювати з полем/методом за допомогою Reflection? <br>Так, можливо. Reflection дозволяє отримати доступ до елементів з модифікатором доступу private за допомогою методу BindingFlags.NonPublic. </li>
  </ol>
</div>
<div id="lab5">
  <h2>Лабораторна робота 5</h2>
  <ol>
    <li>Що таке HTTP? <br> HTTP (Hypertext Transfer Protocol) - це протокол передачі гіпертекстових документів в мережі Інтернет. Він використовується для передачі даних між веб-сервером та клієнтом, який може бути браузером або будь-якою іншою програмою. </li>
    <li>Які групи статус кодів існують? Привести приклади з StatusCodes. <br> Статус-коди HTTP поділяють на 5 груп: <ul>
        <li>1xx - Інформаційні. Наприклад: 100 Continue, 101 Switching Protocols.</li>
        <li>2xx - Успішні. Наприклад: 200 OK, 201 Created.</li>
        <li>3xx - Перенаправлення. Наприклад: 301 Moved Permanently, 302 Found.</li>
        <li>4xx - Помилки клієнта. Наприклад: 400 Bad Request, 401 Unauthorized.</li>
        <li>5xx - Помилки сервера. Наприклад: 500 Internal Server Error, 503 Service Unavailable.</li>
      </ul>
    </li>
    <li>Для яких протоколів HTTP використовується, як базовий «транспортний» протокол? <br> HTTP використовує TCP (Transmission Control Protocol) як базовий "транспортний" протокол. TCP забезпечує доставку даних в порядку їх надсилання, з контролем помилок та перевіркою доставки даних. </li>
    <li>На які групи поділяють програмне забезпечення для роботи з протоколом HTTP? <br> Програмне забезпечення для роботи з протоколом HTTP поділяють на дві групи: <ul>
        <li>Серверне програмне забезпечення - веб-сервери, які надають веб-сторінки клієнтам через HTTP.</li>
        <li>Клієнтське програмне забезпечення - веб-браузери, які взаємодіють з веб-серверами за допомогою HTTP.</li>
      </ul>
    </li>
    <li>Який з методів HTTP запитів не може мати body? <br> HTTP метод "GET" не може мати тіла запиту (body), оскільки він використовується для отримання ресурсів від сервера. Запит "GET" передає параметри запиту через URL, а не через тіло запиту, тому тіло запиту не має сенсу. </li>
  </ol>
</div>

<div id="lab6">
  <h2>Лабораторна робота 6</h2>
  <ol>
  <li>Для чого використовується Swagger?<br>Swagger використовується для автоматичної генерації документації для RESTful веб-сервісів. Він дозволяє описати структуру API, його ресурси, методи та параметри, тим самим полегшуючи розробку та спрощуючи розуміння веб-сервісу.</li>
  <li>Як згенерувати колекцію для Postman, використовуючи Swagger?<br>Щоб згенерувати колекцію для Postman за допомогою Swagger, потрібно відкрити файл Swagger у веб-браузері та натиснути на кнопку "Generate Collection". Після цього можна завантажити файл згенерованої колекції та імпортувати його в Postman.</li>
  <li>Що таке OpenAPI і яке його призначення?<br>OpenAPI (раніше відомий як Swagger) - це незалежний від вендора формат опису веб-сервісів, який дозволяє автоматично генерувати документацію та різні інструменти для тестування веб-сервісів. Його призначення полягає в упрощенні процесу розробки веб-сервісів та полегшенні спілкування між розробниками та користувачами веб-сервісу.</li>
  <li>Як називається вебсервер, що використовується у .NET?<br>Вебсервер, що використовується у .NET, називається IIS (Internet Information Services).</li>
</ol>
</div>

<div id="lab7">
  <h2>Лабораторна робота 7</h2>
  <ol>
<li>Що таке REST API?<br>
REST (Representational State Transfer) API - це архітектурний стиль для створення веб-сервісів, який використовує протокол HTTP для обміну даними між клієнтом та сервером.</li>
<li>У чому різниця між REST і RESTful?<br>
RESTful - це термін, який використовується для опису веб-сервісів, які повністю відповідають принципам REST. Різниця між REST і RESTful полягає у тому, що REST є архітектурним стилем, тоді як RESTful є реалізацією цього стилю.</li>
<li>Які основні HTTP методи використовують для розробки WebAPI? Опишіть призначення кожного.<br>
HTTP методи, які використовують для розробки WebAPI:
<ul>
<li>GET - отримує ресурс з сервера.</li>
<li>POST - створює новий ресурс на сервері.</li>
<li>PUT/PATCH - оновлює існуючий ресурс на сервері.</li>
<li>DELETE - видаляє існуючий ресурс з сервера.</li>
</ul>
</li>
<li>У чому різниця між REST API та JSON API?<br>
REST API - це архітектурний стиль для створення веб-сервісів, який використовує протокол HTTP для обміну даними між клієнтом та сервером, тоді як JSON API - це специфікація для форматування даних, яка забезпечує консистентність даних між клієнтом та сервером, а також оптимізує кількість запитів до сервера.</li>
<li>Які основні принципи для розробки REST API?<br>
Основні принципи для розробки REST API:
<ul>
<li>Кожен ресурс має бути ідентифікований унікальним URI.</li>
<li>Використовуйте HTTP методи правильно для кожної операції.</li>
<li>Ресурси мають бути без стану, тобто кожен запит на ресурс має місцево повну інформацію для його обробки.</li>
<li>Застосовуйте стандартизовані формати даних, такі як JSON або XML, для обміну інформацією між клієнтом і сервером.</li>
</ul>
</div>

<div id="lab8">
  <h2>Лабораторна робота 8</h2>
  <ol>
  <li>В чому різниця між авторизацією і аутентифікацією?<br>
  Аутентифікація - це процес перевірки, чи є користувач тим, за кого він себе видає. Авторизація - це процес контролю доступу до ресурсів системи після успішної аутентифікації. </li>
  <li>Що таке OAuth і для чого використовується?<br>
  OAuth - це відкритий протокол авторизації, який використовується для забезпечення стороннього доступу до ресурсів веб-сайту без викладення логіну та пароля користувача. Цей протокол забезпечує авторизацію через сторонні сервіси, такі як Google або Facebook, і дозволяє користувачам давати стороннім сервісам обмежений доступ до їхніх особистих даних без надання доступу до їх логіну та пароля.</li>
  <li>Які є типи авторизації користувачів?<br>
  Існує декілька типів авторизації користувачів, зокрема авторизація на основі ролей, авторизація на основі дозволів, а також авторизація на основі клеймів (claims-based authorization).</li>
  <li>Який тип авторизації було використано в поточній роботі?<br>
  В поточній роботі було використано авторизацію на основі дозволів.</li>
</ol>
</div>
