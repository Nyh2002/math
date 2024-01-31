Сделать иерархию классов для вычисления математических выражений.
1.	Базовый интерфейс
interface IExpr
{
   double Compute(IReadOnlyDictionary<string, double> variableValues);
          IEnumerable<string> Variables { get; }
          bool IsConstant { get; }
   bool IsPolynom { get; }
}
2.	Абстрактные классы
UnaryOperation, BinaryOperation, Function
3.	Классы реализующие арифметические операции и класс Variable, Constant.
4.	Сделать для этих классов перегрузку операторов и ToString().
5.	Классы реализующие функции (выбрать один, в соответствии с номером бригады)
a.	Степенные
b.	Тригонометрические
c.	Обратные тригонометрические
d.	Гиперболические
e.	Обратные гиперболические
