# Calculadora
### Explicación
**Este código representa una interfaz de usuario de una calculadora básica en C#. La interfaz se crea utilizando Windows Forms.**
> Calculadora
- La clase principal en este código es 'Form1', que representa la ventana de la calculadora. Aquí se definen todos los componentes visuales de la calculadora, como botones y cuadros de texto. El formulario se crea utilizando la biblioteca 'System.Windows.Forms'.
- La mayoría de los componentes son botones (Button) que representan los dígitos numéricos del 0 al 9, los operadores matemáticos (+, -, *, /) y los botones de control (C, CE). También hay un cuadro de texto (TextBox) que muestra los números y los resultados de las operaciones.
- Cada botón tiene un evento Click asociado que se activa cuando el usuario hace clic en el botón. Estos eventos están vinculados a métodos en la clase Form1, que realizan las operaciones correspondientes.
- Por ejemplo, el botón de suma (btnSuma) tiene un evento 'Click' asociado que ejecuta el método 'clickOperador' cuando se hace clic en él. Este método maneja la lógica para agregar el operador de suma al cuadro de texto.
- De manera similar, los botones de dígitos (btnValor1, btnValor2, etc.) tienen eventos 'Click' que ejecutan el método 'agregarNumero' cuando se hace clic en ellos. Este método agrega el número correspondiente al cuadro de texto.

##### En resumen, este código crea una interfaz de calculadora básica en C# utilizando Windows Forms y proporciona la funcionalidad necesaria para realizar operaciones matemáticas.

