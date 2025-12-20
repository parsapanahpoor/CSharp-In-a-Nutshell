<div dir="rtl" style="text-align: right;">

# брЦФД Inheritance оя C#

---

## сФгА 1 (сьм: сгоЕ)

Еощ гуА? гсйщгоЕ гр Inheritance █?сй©

гАщ) гщрг?т сязй гляг? хяДгЦЕ  
х) лАФ░?я? гр й≤ягя ≤о Ф гсйщгоЕ Цлоо гр ≤о (Code Reuse)  
л) ≤гЕт млЦ щг?А гляг??  
о) гщрг?т гЦД?й хяДгЦЕ  

**│гсн ум?м: х**

> **Д≤йЕ:** Inheritance хЕ Цг ≤Ц≤ Ц?²≤До гр гуА DRY (Don't Repeat Yourself) │?яФ? ≤Д?Ц Ф ≤оЕг? й≤ягя? ДДФ?с?Ц.

---

## сФгА 2 (сьм: сгоЕ)

≤огЦ ░р?ДЕ syntax ум?м гяк²хя? оя C# гсй©

гАщ) `class Derived extends Base { }`  
х) `class Derived : Base { }`  
л) `class Derived inherits Base { }`  
о) `class Derived -> Base { }`  

**│гсн ум?м: х**

> **Д≤йЕ:** оя C# гр зАгЦй `:` хяг? гяк²хя? гсйщгоЕ Ц?²тФо (хянАгщ Java ≤Е гр extends гсйщгоЕ Ц?²≤До).

---

## сФгА 3 (сьм: сгоЕ)

оя C# гр █До ≤Агс Ц?²йФгД гяк²хя? ≤яо©

гАщ) хоФД ЦмоФо?й  
х) мог≤кя 2 ≤Агс  
л) щчь ?≤ ≤Агс  
о) мог≤кя 3 ≤Агс  

**│гсн ум?м: л**

> **Д≤йЕ:** C# щчь Single Inheritance яг │тй?хгД? Ц?²≤До гЦг Ц?²йФгД █До?Д Interface яг │?гоЕ²сгр? ≤яо.

---

## сФгА 4 (сьм: сгоЕ)

≤огЦ Access Modifier хЕ ≤Агс²Ег? щярДо (Derived) глгрЕ осйяс? Ц?²оЕо гЦг гр х?яФД чгхА осйяс? Д?сй©

гАщ) `public`  
х) `private`  
л) `protected`  
о) `internal`  

**│гсн ум?м: л**

> **Д≤йЕ:** `protected` хяг? г?лго Extension Points гсйщгоЕ Ц?²тФо ≤Е щчь ≤Агс²Ег? щярДо хйФгДДо хЕ бД осйяс? огтйЕ хгтДо.

---

## сФгА 5 (сьм: сгоЕ)

ЕЦЕ ≤Агс²Ег оя C# гр ≤огЦ ≤Агс гяк Ц?²хяДо©

гАщ) `System.Base`  
х) `System.Object`  
л) `System.Class`  
о) `System.Root`  

**│гсн ум?м: х**

> **Д≤йЕ:** мй? г░я уя?мг ДДФ?с?о║ ЕЦЕ ≤Агс²Ег хЕ уФяй implicit гр `System.Object` гяк Ц?²хяДо.

---

## сФгА 6 (сьм: ЦйФсь)

няФл? ≤о р?я █?сй©

```csharp
class Base {
    public Base() { Console.Write("B"); }
}
class Derived : Base {
    public Derived() { Console.Write("D"); }
}
new Derived();
```

гАщ) `DB`  
х) `BD`  
л) `B`  
о) `D`  

**│гсн ум?м: х**

> **Д≤йЕ:** оя Constructor Chaining ЕЦ?тЕ гхйог Constructor ≤Агс │г?Е (Base) Ф с│с Constructor ≤Агс щярДо (Derived) гляг Ц?²тФо.

---

## сФгА 7 (сьм: ЦйФсь)

≤АЦЕ ≤А?о? `sealed` █Е ≤гяхяо? огяо©

гАщ) глгрЕ Override ≤яоД ЦйоЕг яг Ц?²оЕо  
х) лАФ░?я? гр гяк²хя? гр ≤Агс  
л) ≤Агс яг abstract Ц?²≤До  
о) ≤Агс яг static Ц?²≤До  

**│гсн ум?м: х**

> **Д≤йЕ:** ≤Агс `String` оя .NET ?≤ ≤Агс `sealed` гсй. гсйщгоЕ гр sealed Ц?²йФгДо Performance яг хЕхФо оЕо (Devirtualization).

---

## сФгА 8 (сьм: ЦйФсь)

йщгФй `IS-A` Ф `HAS-A` █?сй©

гАщ) Ея оФ ?≤? ЕсйДо  
х) `IS-A` хяг? Inheritance Ф `HAS-A` хяг? Composition гсй  
л) `IS-A` хяг? Composition Ф `HAS-A` хяг? Inheritance гсй  
о) Е?█≤огЦ хЕ OOP ЦяхФь Д?сйДо  

**│гсн ум?м: х**

> **Д≤йЕ:** "с░ ?≤ м?ФгД гсй" (IS-A = Inheritance) ФА? "Цгт?Д ?≤ ЦФйФя огяо" (HAS-A = Composition).

---

## сФгА 9 (сьм: ЦйФсь)

█яг C# гр Multiple Inheritance │тй?хгД? ДЦ?²≤До©

гАщ) хЕ оА?А ≤До? гляг  
х) хЕ оА?А Цт≤А Diamond Problem  
л) хЕ оА?А ЦмоФо?й мгщыЕ  
о) хЕ оА?А Дгсгр░гя? хг Windows  

**│гсн ум?м: х**

> **Д≤йЕ:** Diamond Problem рЦгД? ян Ц?²оЕо ≤Е оФ ≤Агс │г?Е Цйо ?≤сгД? огтйЕ хгтДо Ф Цтну Дхгто ≤огЦ хг?о гсйщгоЕ тФо.

---

## сФгА 10 (сьм: ЦйФсь)

няФл? ≤о р?я █?сй©

```csharp
class Animal {
    public virtual void Speak() => Console.Write("Animal");
}
class Dog : Animal {
    public override void Speak() => Console.Write("Woof");
}
Animal a = new Dog();
a.Speak();
```

гАщ) `Animal`  
х) `Woof`  
л) `AnimalWoof`  
о) ньг? ≤гЦ│г?А  

**│гсн ум?м: х**

> **Д≤йЕ:** хЕ оА?А Polymorphism Ф Virtual Method Table║ оя Runtime ДФз Фгчз? т? (Dog) Цтну Ц?²тФо Ф `Dog.Speak()` гляг Ц?²тФо.

---

## сФгА 11 (сьм: ЦйФсь)

≤огЦ ░р?ДЕ ояхгяЕ `protected internal` ум?м гсй©

гАщ) щчь оя ≤Агс²Ег? щярДо чгхА осйяс? гсй  
х) щчь оя ЕЦгД Assembly чгхА осйяс? гсй  
л) оя ≤Агс²Ег? щярДо ?г ЕЦгД Assembly чгхА осйяс? гсй  
о) оя ≤Агс²Ег? щярДо Ф ЕЦгД Assembly чгхА осйяс? гсй  

**│гсн ум?м: л**

> **Д≤йЕ:** `protected internal` = `protected` OR `internal` (░сйяоЕ²йя) оя мгА? ≤Е `private protected` = `protected` AND `internal` (ЦмоФойя).

---

## сФгА 12 (сьм: ЦйФсь)

няФл? ≤о р?я █?сй©

```csharp
class Base { public int Value = 10; }
class Derived : Base { public new int Value = 20; }

Base obj = new Derived();
Console.WriteLine(obj.Value);
```

гАщ) `10`  
х) `20`  
л) `0`  
о) ньг? ≤гЦ│г?А  

**│гсн ум?м: гАщ**

> **Д≤йЕ:** Field Hiding (хг `new`) хя гсгс ДФз Цйш?я (Compile-time type) ≤гя Ц?²≤До ДЕ ДФз Фгчз? т?. г?Д ящйгя ньяДг≤ гсй Ф хг?о гр бД глйДгх ≤яо.

---

## сФгА 13 (сьм: ЦйФсь)

≤огЦ зхгяй ум?м гсй©

гАщ) Ц?²йФгД Constructor яг virtual йзя?щ ≤яо  
х) Constructor ДЦ?²йФгДо virtual хгто █ФД Ея ≤Агс Constructor нФот яг огяо  
л) Constructor хЕ уФяй │?т²щяж virtual гсй  
о) Constructor щчь оя ≤Агс²Ег? abstract Ц?²йФгДо virtual хгто  

**│гсн ум?м: х**

> **Д≤йЕ:** уог роД Virtual Method оя Constructor ньяДг≤ гсй █ФД ≤Агс щярДо ЕДФр Initialize ДтоЕ гсй.

---

## сФгА 14 (сьм: │?тящйЕ)

VMT (Virtual Method Table) █?сй©

гАщ) лоФА? хяг? пн?яЕ Цйш?яЕг? static  
х) лоФА? ≤Е оя Runtime хяг? ?гщйД │?гоЕ²сгр? ум?м ЦйоЕг? virtual гсйщгоЕ Ц?²тФо  
л) лоФА? хяг? пн?яЕ ConstructorЕг  
о) лоФА? хяг? Цо?я?й мгщыЕ  

**│гсн ум?м: х**

> **Д≤йЕ:** Ея т? ?≤ Type Handle огяо ≤Е хЕ VMT гтгяЕ Ц?²≤До. Runtime гр г?Д лоФА хяг? ?гщйД Цйо Override тоЕ гсйщгоЕ Ц?²≤До.

---

## сФгА 15 (сьм: │?тящйЕ)

гуА LSP (Liskov Substitution Principle) █Е Ц?²░Ф?о©

гАщ) ЕЦ?тЕ гр Inheritance хЕ лг? Composition гсйщгоЕ ≤Д?о  
х) Ея лг ≤Е Base Class гсйщгоЕ тоЕ║ хг?о хйФгД Derived Class яг лг?░р?Д ≤яо хоФД йш??я ящйгя  
л) ≤Агс²Ег? щярДо хг?о ЕЦЕ ЦйоЕг? ≤Агс │г?Е яг Override ≤ДДо  
о) ≤Агс │г?Е Дхг?о Е?█ │?гоЕ²сгр? огтйЕ хгто  

**│гсн ум?м: х**

> **Д≤йЕ:** ЦкгА ЦзяФщ Дчж LSP: Square ≤Е гр Rectangle гяк Ц?²хяо. █ФД Цяхз ящйгя ЦйщгФй? огяо║ Дхг?о гр Цсйь?А гяк ххяо.

---

## сФгА 16 (сьм: │?тящйЕ)

оя Memory Layout ?≤ т?║ щ?АоЕг хЕ █Е йяй?х? █?оЕ Ц?²тФДо©

гАщ) гхйог щ?АоЕг? Derived с│с Base  
х) гхйог щ?АоЕг? Base с│с Derived  
л) хЕ йяй?х гАщхг??  
о) хЕ уФяй йугощ?  

**│гсн ум?м: х**

> **Д≤йЕ:** оя Heap║ гхйог Object Header║ с│с Type Handle║ хзо щ?АоЕг? Base Ф оя бня щ?АоЕг? Derived █?оЕ Ц?²тФДо.

---

## сФгА 17 (сьм: │?тящйЕ)

█яг `base.base` оя C# ФлФо Догяо©

гАщ) хЕ оА?А ЦмоФо?й Compiler  
х) хяг? мщы Encapsulation Ф лАФ░?я? гр т≤сйД сАсАЕ²Цягйх Фягкй  
л) хЕ оА?А ≤ЦхФо мгщыЕ  
о) оя ДснЕ²Ег? ло?о C# гжгщЕ тоЕ гсй  

**│гсн ум?м: х**

> **Д≤йЕ:** г░я Д?гр хЕ осйяс? хЕ GrandParent огя?о║ хг?о гр ья?ч Цйо protected оя Parent г?Д ≤гя яг гДлгЦ оЕ?о (Indirect Access).

---

## сФгА 18 (сьм: │?тящйЕ)

Covariant Return Types (гр C# 9) хЕ █Е ЦзДгсй©

гАщ) Цйо Override тоЕ Ц?²йФгДо │гягЦйя ЦйщгФй огтйЕ хгто  
х) Цйо Override тоЕ Ц?²йФгДо ДФз хгр░тй? Derived хя░яогДо  
л) Цйо Override тоЕ Ц?²йФгДо ДгЦ ЦйщгФй огтйЕ хгто  
о) Цйо Override тоЕ Ц?²йФгДо private хгто  

**│гсн ум?м: х**

> **Д≤йЕ:** чхА гр C# 9║ г░я Base Цйо? хг няФл? `Animal` огтй║ Derived ЕЦ хг?о оч?чг `Animal` хя░яогДо. гЦг гАгД Ц?²йФгДо `Dog` (≤Е гр Animal гяк Ц?²хяо) хя░яогДо.

---

## сФгА 19 (сьм: │?тящйЕ)

йяй?х ум?м Field Initialization оя Inheritance █?сй©

гАщ) Derived Fields - Base Fields - Base Constructor - Derived Constructor  
х) Base Fields - Base Constructor - Derived Fields - Derived Constructor  
л) Base Constructor - Derived Constructor - Base Fields - Derived Fields  
о) Derived Fields - Derived Constructor - Base Fields - Base Constructor  

**│гсн ум?м: гАщ**

> **Д≤йЕ:** гхйог щ?АоЕг? Derived║ с│с щ?АоЕг? Base║ хзо Constructor Base Ф оя бня Constructor Derived гляг Ц?²тФДо. г?Д йяй?х Ц?²йФгДо хгзк bug тФо!

---

## сФгА 20 (сьм: │?тящйЕ)

оя ≤о р?я║ ≤огЦ ░р?ДЕ ум?м гсй©

```csharp
class Base<T> where T : Animal { }
class Derived<T> : Base<T> where T : Dog { }
```

гАщ) ньг? ≤гЦ│г?А Ц?²оЕо  
х) ум?м гсй █ФД Dog гр Animal гяк Ц?²хяо (Constraint ЦмоФойя Цлгр гсй)  
л) щчь оя .NET 7 ≤гя Ц?²≤До  
о) Д?гр хЕ ≤АЦЕ ≤А?о? new огяо  

**│гсн ум?м: х**

> **Д≤йЕ:** оя Generic Inheritance║ ≤Агс щярДо Ц?²йФгДо Constraint ЦмоФойя? огтйЕ хгто (Dog хЕ лг? Animal) █ФД Dog нФот ?≤ Animal гсй.

---

## лоФА ДЦяЕ²оЕ?

| йзого │гсн ум?м | ДЦяЕ | сьм |
|-----------------|------|-----|
| 18-20 | згА? | A |
| 14-17 | нФх | B |
| 10-13 | ЦйФсь | C |
| ≤Цйя гр 10 | Д?гр хЕ ЦьгАзЕ х?тйя | D |

</div>
