using MyApp.Database;
using MyApp.Models;
using System.Linq;

namespace MyApp.Database
{
    public static class DatabaseInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return; // База данных уже содержит данные
            }

            // Добавление пользователей
            var users = new User[]
            {
                new User { Username = "1", Password = "1" },
            };
            context.Users.AddRange(users);

            // Добавление тем и слов
            var themes = new Theme[]
            {
                new Theme
                {
                    Name = "Животные",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Dog", Translation = "Собака", ExampleSentence = "I have a dog.", ExampleSentenceTranslation = "У меня есть собака." },
                        new Word { EnglishWord = "Cat", Translation = "Кошка", ExampleSentence = "She has a cat.", ExampleSentenceTranslation = "У нее есть кошка." },
                        new Word { EnglishWord = "Elephant", Translation = "Слон", ExampleSentence = "The elephant is the largest land animal.", ExampleSentenceTranslation = "Слон — самый крупный наземный животное." },
                        new Word { EnglishWord = "Tiger", Translation = "Тигр", ExampleSentence = "The tiger is a powerful predator.", ExampleSentenceTranslation = "Тигр — могучий хищник." },
                        new Word { EnglishWord = "Lion", Translation = "Лев", ExampleSentence = "The lion is known as the king of the jungle.", ExampleSentenceTranslation = "Лев известен как король джунглей." },
                        new Word { EnglishWord = "Giraffe", Translation = "Жираф", ExampleSentence = "The giraffe has a very long neck.", ExampleSentenceTranslation = "У жирафа очень длинная шея." },
                        new Word { EnglishWord = "Monkey", Translation = "Обезьяна", ExampleSentence = "The monkey is swinging from tree to tree.", ExampleSentenceTranslation = "Обезьяна качается с дерева на дерево." },
                        new Word { EnglishWord = "Dolphin", Translation = "Дельфин", ExampleSentence = "The dolphin is a friendly sea creature.", ExampleSentenceTranslation = "Дельфин — дружелюбное морское животное." },
                        new Word { EnglishWord = "Penguin", Translation = "Пингвин", ExampleSentence = "The penguin lives in cold climates.", ExampleSentenceTranslation = "Пингвин живет в холодных климатах." },
                        new Word { EnglishWord = "Kangaroo", Translation = "Кенгуру", ExampleSentence = "The kangaroo hops across the grassland.", ExampleSentenceTranslation = "Кенгуру скачет по лугам." },
                        new Word { EnglishWord = "Bear", Translation = "Медведь", ExampleSentence = "The bear is a strong animal.", ExampleSentenceTranslation = "Медведь — сильное животное." },
                        new Word { EnglishWord = "Wolf", Translation = "Волк", ExampleSentence = "The wolf howls at the moon.", ExampleSentenceTranslation = "Волк воет на луну." },
                        new Word { EnglishWord = "Fox", Translation = "Лиса", ExampleSentence = "The fox is a clever animal.", ExampleSentenceTranslation = "Лиса — хитрое животное." },
                        new Word { EnglishWord = "Rabbit", Translation = "Кролик", ExampleSentence = "The rabbit is jumping around.", ExampleSentenceTranslation = "Кролик прыгает вокруг." },
                        new Word { EnglishWord = "Horse", Translation = "Лошадь", ExampleSentence = "The horse is running in the field.", ExampleSentenceTranslation = "Лошадь бежит по полю." },
                        new Word { EnglishWord = "Cow", Translation = "Корова", ExampleSentence = "The cow is eating grass.", ExampleSentenceTranslation = "Корова ест траву." },
                        new Word { EnglishWord = "Sheep", Translation = "Овца", ExampleSentence = "The sheep is grazing in the meadow.", ExampleSentenceTranslation = "Овца пасется на лугу." },
                        new Word { EnglishWord = "Pig", Translation = "Свинья", ExampleSentence = "The pig is rolling in the mud.", ExampleSentenceTranslation = "Свинья валяется в грязи." },
                        new Word { EnglishWord = "Deer", Translation = "Олень", ExampleSentence = "The deer is hiding in the forest.", ExampleSentenceTranslation = "Олень прячется в лесу." },
                        new Word { EnglishWord = "Zebra", Translation = "Зебра", ExampleSentence = "The zebra has black and white stripes.", ExampleSentenceTranslation = "У зебры черные и белые полосы." }
                    }
                },
                new Theme
                {
                    Name = "Цвета",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Red", Translation = "Красный", ExampleSentence = "The apple is red.", ExampleSentenceTranslation = "Яблоко красное." },
                        new Word { EnglishWord = "Blue", Translation = "Синий", ExampleSentence = "The sky is blue.", ExampleSentenceTranslation = "Небо синее." },
                        new Word { EnglishWord = "Green", Translation = "Зеленый", ExampleSentence = "The grass is green.", ExampleSentenceTranslation = "Трава зеленая." },
                        new Word { EnglishWord = "Yellow", Translation = "Желтый", ExampleSentence = "The sun is yellow.", ExampleSentenceTranslation = "Солнце желтое." },
                        new Word { EnglishWord = "Orange", Translation = "Оранжевый", ExampleSentence = "The orange is orange.", ExampleSentenceTranslation = "Апельсин оранжевый." },
                        new Word { EnglishWord = "Purple", Translation = "Фиолетовый", ExampleSentence = "The grapes are purple.", ExampleSentenceTranslation = "Виноград фиолетовый." },
                        new Word { EnglishWord = "Pink", Translation = "Розовый", ExampleSentence = "The flowers are pink.", ExampleSentenceTranslation = "Цветы розовые." },
                        new Word { EnglishWord = "Black", Translation = "Черный", ExampleSentence = "The cat is black.", ExampleSentenceTranslation = "Кот черный." },
                        new Word { EnglishWord = "White", Translation = "Белый", ExampleSentence = "The snow is white.", ExampleSentenceTranslation = "Снег белый." },
                        new Word { EnglishWord = "Brown", Translation = "Коричневый", ExampleSentence = "The bear is brown.", ExampleSentenceTranslation = "Медведь коричневый." },
                        new Word { EnglishWord = "Gray", Translation = "Серый", ExampleSentence = "The elephant is gray.", ExampleSentenceTranslation = "Слон серый." },
                        new Word { EnglishWord = "Gold", Translation = "Золотой", ExampleSentence = "The medal is gold.", ExampleSentenceTranslation = "Медаль золотая." },
                        new Word { EnglishWord = "Silver", Translation = "Серебряный", ExampleSentence = "The ring is silver.", ExampleSentenceTranslation = "Кольцо серебряное." },
                        new Word { EnglishWord = "Violet", Translation = "Фиолетовый", ExampleSentence = "The flower is violet.", ExampleSentenceTranslation = "Цветок фиолетовый." },
                        new Word { EnglishWord = "Indigo", Translation = "Индиго", ExampleSentence = "The dye is indigo.", ExampleSentenceTranslation = "Краситель индиго." },
                        new Word { EnglishWord = "Turquoise", Translation = "Бирюзовый", ExampleSentence = "The water is turquoise.", ExampleSentenceTranslation = "Вода бирюзовая." },
                        new Word { EnglishWord = "Magenta", Translation = "Пурпурный", ExampleSentence = "The dress is magenta.", ExampleSentenceTranslation = "Платье пурпурное." },
                        new Word { EnglishWord = "Cyan", Translation = "Голубой", ExampleSentence = "The sky is cyan.", ExampleSentenceTranslation = "Небо голубое." },
                        new Word { EnglishWord = "Beige", Translation = "Бежевый", ExampleSentence = "The carpet is beige.", ExampleSentenceTranslation = "Ковер бежевый." },
                        new Word { EnglishWord = "Maroon", Translation = "Бордовый", ExampleSentence = "The wine is maroon.", ExampleSentenceTranslation = "Вино бордовое." }
                    }
                },
                new Theme
                {
                    Name = "Еда",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Pizza", Translation = "Пицца", ExampleSentence = "I love pizza.", ExampleSentenceTranslation = "Я люблю пиццу." },
                        new Word { EnglishWord = "Burger", Translation = "Бургер", ExampleSentence = "He ordered a burger.", ExampleSentenceTranslation = "Он заказал бургер." },
                        new Word { EnglishWord = "Pasta", Translation = "Паста", ExampleSentence = "She cooked pasta for dinner.", ExampleSentenceTranslation = "Она приготовила пасту на ужин." },
                        new Word { EnglishWord = "Salad", Translation = "Салат", ExampleSentence = "The salad is very fresh.", ExampleSentenceTranslation = "Салат очень свежий." },
                        new Word { EnglishWord = "Soup", Translation = "Суп", ExampleSentence = "The soup is hot and tasty.", ExampleSentenceTranslation = "Суп горячий и вкусный." },
                        new Word { EnglishWord = "Bread", Translation = "Хлеб", ExampleSentence = "We need to buy some bread.", ExampleSentenceTranslation = "Нам нужно купить хлеба." },
                        new Word { EnglishWord = "Cheese", Translation = "Сыр", ExampleSentence = "The cheese is very creamy.", ExampleSentenceTranslation = "Сыр очень сливочный." },
                        new Word { EnglishWord = "Egg", Translation = "Яйцо", ExampleSentence = "I boiled an egg for breakfast.", ExampleSentenceTranslation = "Я сварил яйцо на завтрак." },
                        new Word { EnglishWord = "Fish", Translation = "Рыба", ExampleSentence = "The fish is grilled to perfection.", ExampleSentenceTranslation = "Рыба запечена до совершенства." },
                        new Word { EnglishWord = "Fruit", Translation = "Фрукт", ExampleSentence = "We eat fruit every day.", ExampleSentenceTranslation = "Мы едим фрукты каждый день." },
                        new Word { EnglishWord = "Vegetable", Translation = "Овощ", ExampleSentence = "I love eating vegetables.", ExampleSentenceTranslation = "Я люблю есть овощи." },
                        new Word { EnglishWord = "Meat", Translation = "Мясо", ExampleSentence = "He cooked some meat for dinner.", ExampleSentenceTranslation = "Он приготовил мясо на ужин." },
                        new Word { EnglishWord = "Chicken", Translation = "Курица", ExampleSentence = "The chicken is very tender.", ExampleSentenceTranslation = "Курица очень нежная." },
                        new Word { EnglishWord = "Beef", Translation = "Говядина", ExampleSentence = "We had beef for dinner.", ExampleSentenceTranslation = "Мы ели говядину на ужин." },
                        new Word { EnglishWord = "Pork", Translation = "Свинина", ExampleSentence = "The pork is very juicy.", ExampleSentenceTranslation = "Свинина очень сочная." },
                        new Word { EnglishWord = "Lamb", Translation = "Баранина", ExampleSentence = "The lamb is a traditional dish.", ExampleSentenceTranslation = "Баранина — традиционное блюдо." },
                        new Word { EnglishWord = "Dessert", Translation = "Десерт", ExampleSentence = "We had dessert after dinner.", ExampleSentenceTranslation = "Мы ели десерт после ужина." },
                        new Word { EnglishWord = "Cake", Translation = "Торт", ExampleSentence = "The cake was delicious.", ExampleSentenceTranslation = "Торт был вкусным." },
                        new Word { EnglishWord = "Ice cream", Translation = "Мороженое", ExampleSentence = "I love ice cream.", ExampleSentenceTranslation = "Я люблю мороженое." },
                        new Word { EnglishWord = "Chocolate", Translation = "Шоколад", ExampleSentence = "The chocolate is very sweet.", ExampleSentenceTranslation = "Шоколад очень сладкий." }
                    }
                },
                new Theme
                {
                    Name = "Семья",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Mother", Translation = "Мама", ExampleSentence = "My mother is a teacher.", ExampleSentenceTranslation = "Моя мама учитель." },
                        new Word { EnglishWord = "Father", Translation = "Папа", ExampleSentence = "My father works in an office.", ExampleSentenceTranslation = "Мой папа работает в офисе." },
                        new Word { EnglishWord = "Sister", Translation = "Сестра", ExampleSentence = "My sister is younger than me.", ExampleSentenceTranslation = "Моя сестра младше меня." },
                        new Word { EnglishWord = "Brother", Translation = "Брат", ExampleSentence = "My brother loves playing video games.", ExampleSentenceTranslation = "Мой брат любит играть в видеоигры." },
                        new Word { EnglishWord = "Grandmother", Translation = "Бабушка", ExampleSentence = "My grandmother bakes the best cookies.", ExampleSentenceTranslation = "Моя бабушка печет лучшие печенья." },
                        new Word { EnglishWord = "Grandfather", Translation = "Дедушка", ExampleSentence = "My grandfather enjoys gardening.", ExampleSentenceTranslation = "Мой дедушка любит заниматься садоводством." },
                        new Word { EnglishWord = "Aunt", Translation = "Тетя", ExampleSentence = "My aunt lives in another city.", ExampleSentenceTranslation = "Моя тетя живет в другом городе." },
                        new Word { EnglishWord = "Uncle", Translation = "Дядя", ExampleSentence = "My uncle is a doctor.", ExampleSentenceTranslation = "Мой дядя врач." },
                        new Word { EnglishWord = "Cousin", Translation = "Двоюродный брат/сестра", ExampleSentence = "My cousin is coming to visit next week.", ExampleSentenceTranslation = "Мой двоюродный брат/сестра приедет навестить на следующей неделе." },
                        new Word { EnglishWord = "Family", Translation = "Семья", ExampleSentence = "My family is very important to me.", ExampleSentenceTranslation = "Моя семья очень важна для меня." },
                        new Word { EnglishWord = "Parent", Translation = "Родитель", ExampleSentence = "My parents are very kind.", ExampleSentenceTranslation = "Мои родители очень добрые." },
                        new Word { EnglishWord = "Child", Translation = "Ребенок", ExampleSentence = "The child is playing with toys.", ExampleSentenceTranslation = "Ребенок играет с игрушками." },
                        new Word { EnglishWord = "Son", Translation = "Сын", ExampleSentence = "My son is very smart.", ExampleSentenceTranslation = "Мой сын очень умный." },
                        new Word { EnglishWord = "Daughter", Translation = "Дочь", ExampleSentence = "My daughter loves to dance.", ExampleSentenceTranslation = "Моя дочь любит танцевать." },
                        new Word { EnglishWord = "Nephew", Translation = "Племянник", ExampleSentence = "My nephew is very funny.", ExampleSentenceTranslation = "Мой племянник очень смешной." },
                        new Word { EnglishWord = "Niece", Translation = "Племянница", ExampleSentence = "My niece is very talented.", ExampleSentenceTranslation = "Моя племянница очень талантливая." },
                        new Word { EnglishWord = "Husband", Translation = "Муж", ExampleSentence = "My husband is very supportive.", ExampleSentenceTranslation = "Мой муж очень поддерживает." },
                        new Word { EnglishWord = "Wife", Translation = "Жена", ExampleSentence = "My wife is a great cook.", ExampleSentenceTranslation = "Моя жена отличный повар." },
                        new Word { EnglishWord = "Sibling", Translation = "Брат или сестра", ExampleSentence = "I have two siblings.", ExampleSentenceTranslation = "У меня есть два брата/сестры." },
                        new Word { EnglishWord = "In-law", Translation = "Зять/Невестка", ExampleSentence = "My in-laws are very nice.", ExampleSentenceTranslation = "Мои родственники по браку очень милые." }
                    }
                },
                new Theme
                {
                    Name = "Спорт",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Football", Translation = "Футбол", ExampleSentence = "He plays football every weekend.", ExampleSentenceTranslation = "Он играет в футбол каждые выходные." },
                        new Word { EnglishWord = "Basketball", Translation = "Баскетбол", ExampleSentence = "They watched a basketball game on TV.", ExampleSentenceTranslation = "Они смотрели баскетбольный матч по телевизору." },
                        new Word { EnglishWord = "Tennis", Translation = "Теннис", ExampleSentence = "She is a professional tennis player.", ExampleSentenceTranslation = "Она профессиональная теннисистка." },
                        new Word { EnglishWord = "Swimming", Translation = "Плавание", ExampleSentence = "Swimming is a great way to stay fit.", ExampleSentenceTranslation = "Плавание — отличный способ оставаться в форме." },
                        new Word { EnglishWord = "Running", Translation = "Бег", ExampleSentence = "He goes running every morning.", ExampleSentenceTranslation = "Он бегает каждое утро." },
                        new Word { EnglishWord = "Cycling", Translation = "Велосипед", ExampleSentence = "Cycling is a popular outdoor activity.", ExampleSentenceTranslation = "Велосипед — популярная активность на свежем воздухе." },
                        new Word { EnglishWord = "Golf", Translation = "Гольф", ExampleSentence = "They played a round of golf on Sunday.", ExampleSentenceTranslation = "Они играли в гольф в воскресенье." },
                        new Word { EnglishWord = "Volleyball", Translation = "Волейбол", ExampleSentence = "The volleyball match was very exciting.", ExampleSentenceTranslation = "Волейбольный матч был очень захватывающим." },
                        new Word { EnglishWord = "Boxing", Translation = "Бокс", ExampleSentence = "He is training for a boxing competition.", ExampleSentenceTranslation = "Он тренируется для боксерского соревнования." },
                        new Word { EnglishWord = "Hockey", Translation = "Хоккей", ExampleSentence = "The hockey team won the championship.", ExampleSentenceTranslation = "Хоккейная команда выиграла чемпионат." },
                        new Word { EnglishWord = "Cricket", Translation = "Крикет", ExampleSentence = "Cricket is very popular in India.", ExampleSentenceTranslation = "Крикет очень популярен в Индии." },
                        new Word { EnglishWord = "Rugby", Translation = "Регби", ExampleSentence = "Rugby is a tough sport.", ExampleSentenceTranslation = "Регби — тяжелый спорт." },
                        new Word { EnglishWord = "Athletics", Translation = "Легкая атлетика", ExampleSentence = "She participates in athletics.", ExampleSentenceTranslation = "Она участвует в легкой атлетике." },
                        new Word { EnglishWord = "Wrestling", Translation = "Борьба", ExampleSentence = "Wrestling is a traditional sport.", ExampleSentenceTranslation = "Борьба — традиционный спорт." },
                        new Word { EnglishWord = "Skiing", Translation = "Лыжи", ExampleSentence = "He loves skiing in the mountains.", ExampleSentenceTranslation = "Он любит кататься на лыжах в горах." },
                        new Word { EnglishWord = "Snowboarding", Translation = "Сноуборд", ExampleSentence = "Snowboarding is very popular among young people.", ExampleSentenceTranslation = "Сноубординг популярен среди молодежи." },
                        new Word { EnglishWord = "Surfing", Translation = "Серфинг", ExampleSentence = "Surfing is a fun water sport.", ExampleSentenceTranslation = "Серфинг — веселое водное развлечение." },
                        new Word { EnglishWord = "Diving", Translation = "Дайвинг", ExampleSentence = "Diving is a great way to explore the ocean.", ExampleSentenceTranslation = "Дайвинг — отличный способ исследовать океан." },
                        new Word { EnglishWord = "Archery", Translation = "Стрельба из лука", ExampleSentence = "Archery is a precision sport.", ExampleSentenceTranslation = "Стрельба из лука — точный спорт." },
                        new Word { EnglishWord = "Fencing", Translation = "Фехтование", ExampleSentence = "Fencing is a classical sport.", ExampleSentenceTranslation = "Фехтование — классический спорт." }
                    }
                },
                new Theme
                {
                    Name = "Одежда",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "Shirt", Translation = "Рубашка", ExampleSentence = "He wore a white shirt to the party.", ExampleSentenceTranslation = "Он надел белую рубашку на вечеринку." },
                        new Word { EnglishWord = "Pants", Translation = "Брюки", ExampleSentence = "She bought a new pair of pants.", ExampleSentenceTranslation = "Она купила новую пару брюк." },
                        new Word { EnglishWord = "Dress", Translation = "Платье", ExampleSentence = "The dress was very elegant.", ExampleSentenceTranslation = "Платье было очень элегантным." },
                        new Word { EnglishWord = "Shoes", Translation = "Обувь", ExampleSentence = "He bought a new pair of shoes.", ExampleSentenceTranslation = "Он купил новую пару обуви." },
                        new Word { EnglishWord = "Jacket", Translation = "Куртка", ExampleSentence = "She put on her jacket before going out.", ExampleSentenceTranslation = "Она надела куртку перед выходом." },
                        new Word { EnglishWord = "Hat", Translation = "Шляпа", ExampleSentence = "He wore a hat to protect himself from the sun.", ExampleSentenceTranslation = "Он надел шляпу, чтобы защититься от солнца." },
                        new Word { EnglishWord = "Socks", Translation = "Носки", ExampleSentence = "I forgot to pack my socks.", ExampleSentenceTranslation = "Я забыл упаковать свои носки." },
                        new Word { EnglishWord = "Gloves", Translation = "Перчатки", ExampleSentence = "She wore gloves to keep her hands warm.", ExampleSentenceTranslation = "Она надела перчатки, чтобы согреть руки." },
                        new Word { EnglishWord = "Scarf", Translation = "Шарф", ExampleSentence = "He wrapped a scarf around his neck.", ExampleSentenceTranslation = "Он обвил шарф вокруг шеи." },
                        new Word { EnglishWord = "Tie", Translation = "Галстук", ExampleSentence = "He wore a tie for the formal event.", ExampleSentenceTranslation = "Он надел галстук на официальное мероприятие." },
                        new Word { EnglishWord = "Coat", Translation = "Пальто", ExampleSentence = "She bought a new coat for the winter.", ExampleSentenceTranslation = "Она купила новое пальто на зиму." },
                        new Word { EnglishWord = "Sweater", Translation = "Свитер", ExampleSentence = "He wore a sweater to keep warm.", ExampleSentenceTranslation = "Он надел свитер, чтобы согреться." },
                        new Word { EnglishWord = "Jeans", Translation = "Джинсы", ExampleSentence = "She loves wearing jeans.", ExampleSentenceTranslation = "Она любит носить джинсы." },
                        new Word { EnglishWord = "Skirt", Translation = "Юбка", ExampleSentence = "The skirt is very stylish.", ExampleSentenceTranslation = "Юбка очень стильная." },
                        new Word { EnglishWord = "Blouse", Translation = "Блузка", ExampleSentence = "She wore a blouse to work.", ExampleSentenceTranslation = "Она надела блузку на работу." },
                        new Word { EnglishWord = "Suit", Translation = "Костюм", ExampleSentence = "He wore a suit to the wedding.", ExampleSentenceTranslation = "Он надел костюм на свадьбу." },
                        new Word { EnglishWord = "Boots", Translation = "Ботинки", ExampleSentence = "The boots are very comfortable.", ExampleSentenceTranslation = "Ботинки очень удобные." },
                        new Word { EnglishWord = "Sandals", Translation = "Сандалии", ExampleSentence = "She wore sandals in the summer.", ExampleSentenceTranslation = "Она носила сандалии летом." },
                        new Word { EnglishWord = "Heels", Translation = "Туфли на каблуке", ExampleSentence = "The heels are very high.", ExampleSentenceTranslation = "Туфли на каблуке очень высокие." },
                        new Word { EnglishWord = "Belt", Translation = "Ремень", ExampleSentence = "He wore a belt with his jeans.", ExampleSentenceTranslation = "Он надел ремень с джинсами." }
                    }
                },
                new Theme
                {
                    Name = "Города",
                    Words = new List<Word>
                    {
                        new Word { EnglishWord = "New York", Translation = "Нью-Йорк", ExampleSentence = "New York is a big city.", ExampleSentenceTranslation = "Нью-Йорк — большой город." },
                        new Word { EnglishWord = "London", Translation = "Лондон", ExampleSentence = "London is the capital of England.", ExampleSentenceTranslation = "Лондон — столица Англии." },
                        new Word { EnglishWord = "Paris", Translation = "Париж", ExampleSentence = "Paris is famous for its Eiffel Tower.", ExampleSentenceTranslation = "Париж известен своей Эйфелевой башней." },
                        new Word { EnglishWord = "Tokyo", Translation = "Токио", ExampleSentence = "Tokyo is a very modern city.", ExampleSentenceTranslation = "Токио — очень современный город." },
                        new Word { EnglishWord = "Moscow", Translation = "Москва", ExampleSentence = "Moscow is the capital of Russia.", ExampleSentenceTranslation = "Москва — столица России." },
                        new Word { EnglishWord = "Beijing", Translation = "Пекин", ExampleSentence = "Beijing is the capital of China.", ExampleSentenceTranslation = "Пекин — столица Китая." },
                        new Word { EnglishWord = "Berlin", Translation = "Берлин", ExampleSentence = "Berlin is the capital of Germany.", ExampleSentenceTranslation = "Берлин — столица Германии." },
                        new Word { EnglishWord = "Rome", Translation = "Рим", ExampleSentence = "Rome is the capital of Italy.", ExampleSentenceTranslation = "Рим — столица Италии." },
                        new Word { EnglishWord = "Madrid", Translation = "Мадрид", ExampleSentence = "Madrid is the capital of Spain.", ExampleSentenceTranslation = "Мадрид — столица Испании." },
                        new Word { EnglishWord = "Sydney", Translation = "Сидней", ExampleSentence = "Sydney is a beautiful city in Australia.", ExampleSentenceTranslation = "Сидней — красивый город в Австралии." },
                        new Word { EnglishWord = "Toronto", Translation = "Торонто", ExampleSentence = "Toronto is a big city in Canada.", ExampleSentenceTranslation = "Торонто — большой город в Канаде." },
                        new Word { EnglishWord = "Seoul", Translation = "Сеул", ExampleSentence = "Seoul is the capital of South Korea.", ExampleSentenceTranslation = "Сеул — столица Южной Кореи." },
                        new Word { EnglishWord = "Bangkok", Translation = "Бангкок", ExampleSentence = "Bangkok is a popular tourist destination.", ExampleSentenceTranslation = "Бангкок — популярный туристический目的地." },
                        new Word { EnglishWord = "Cairo", Translation = "Каир", ExampleSentence = "Cairo is the capital of Egypt.", ExampleSentenceTranslation = "Каир — столица Египта." },
                        new Word { EnglishWord = "Mumbai", Translation = "Мумбаи", ExampleSentence = "Mumbai is a big city in India.", ExampleSentenceTranslation = "Мумбаи — большой город в Индии." },
                        new Word { EnglishWord = "São Paulo", Translation = "Сан-Паулу", ExampleSentence = "São Paulo is a big city in Brazil.", ExampleSentenceTranslation = "Сан-Паулу — большой город в Бразилии." },
                        new Word { EnglishWord = "Mexico City", Translation = "Мехико", ExampleSentence = "Mexico City is the capital of Mexico.", ExampleSentenceTranslation = "Мехико — столица Мексики." },
                        new Word { EnglishWord = "Buenos Aires", Translation = "Буэнос-Айрес", ExampleSentence = "Buenos Aires is the capital of Argentina.", ExampleSentenceTranslation = "Буэнос-Айрес — столица Аргентины." },
                        new Word { EnglishWord = "Cape Town", Translation = "Кейптаун", ExampleSentence = "Cape Town is a beautiful city in South Africa.", ExampleSentenceTranslation = "Кейптаун — красивый город в Южной Африке." },
                        new Word { EnglishWord = "Vancouver", Translation = "Ванкувер", ExampleSentence = "Vancouver is a beautiful city in Canada.", ExampleSentenceTranslation = "Ванкувер — красивый город в Канаде." }
                    }
                }
            };

            context.Themes.AddRange(themes);
            context.SaveChanges();
        }
    }
}