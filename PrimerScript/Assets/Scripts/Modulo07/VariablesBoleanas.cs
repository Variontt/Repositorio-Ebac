using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBoleanas : MonoBehaviour
{

    bool Variable01;
    bool Variable02;              // En esta parte creamos las variables, su valor por defecto de las BOLEANAS es falso.
    bool Variable03;
    int Valor01 = 5;

    // ------------------------ Switchers -----------------------

    int LimiteInferior = -5;
    int LimiteSuperior = 5;
    enum SeleccionDeColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

    // 0 = False
    // 1 = True
    //                    B or C      B and C        
    // A    B    C       OR (||)      And (&&)       ((A or B) and C)     ((A or B) or C)
    // 1    1    1           1           1                  1                     1                                                        
    // 1    1    0           1           0                  0                     1                                                        
    // 1    0    1           1           0                  1                     1                                                       
    // 1    0    0           0           0                  0                     1                                                        
    // 0    1    1           1           1                  1                     1                                                        
    // 0    1    0           1           0                  0                     1                                                        
    // 0    0    1           1           0                  0                     1                                                        
    // 0    0    0           0           0                  0                     0                                                        

    // Start is called before the first frame update
    void Start()
    {
        Variable01 = true;    /// Se puede cambiar el valor de las boleanas es lo que hacemos aquí
        Variable02 = false;
        Variable03 = true;

        // Podemos dejar solo " if(Variable01) " de esta forma el programa pregunta por automatico si es True
        // si ponemos  " if(!Varbiale01 "  el signo de admiración al principio preguntara por default si es False
        // Igual podemos hacer lo siguiente " if(Variable01 == true)  o  if(Variable01 == false) " el == pregunta si es igual a.
        // después de poner el "if(variable)" Podemos poner una línea si solo es ÚNA acción la que se tomara al evaluar el True or False
        // Si se tomaran más de una acción al evaluar el True or False entonces  debemos poner {}
        // Ejemplo:  if (Variable01) Debug.Log("Solo se hizo una acción");

        // Ejemplo 02: if (Variable01) 
        //             {
        //             Debug.Log("Acción 01");
        //             Debug.Log("Acción 02");
        //             } 

        if (Variable01)
        {
            Debug.Log("Completada Acción 01");
            Debug.Log("Completada Acción 02");
        }

        //Para Valor númericos como intergear, floats, etc se tienen que preguntar por que tipo de valor sera (que número) e igual se pregunta
        // con signos si es mayor o menor
        // <  "Menor que"       >  "Mayor que"    == "Igual que"   <= "Menor o igual que"   >=Mayor o igual que    
        if (Valor01 <= 5)
        {
            Debug.Log("Accion 03");
            Debug.Log("Accion 04");
        }

        if (Variable01 && Variable02) // El && es And aqui preguntamos Si la Variable 01 Y la variable 02 son verdaderas ENTONCES
        {
            Debug.Log("Son Verdaderas");
        }

        else // else es para decir que acción prosigue si no se cumplen los parametros de arriba en este caso si son Falsas.
        {
            Debug.Log("Son Falsas");
        }

        if (Variable01 || Variable02) // Aquí estamos usando OR ( || ) si la variable 1 O la Variable 2 son verdaderos entonces:  *Nota aqui la variable 2 es falsa e igual da verdadero
        {
            Debug.Log("Verdadero");
        }

        // -----------------------------------

        if ((Variable01 && Variable02) || Variable03) // aqui preguntamos primero si variablo 1 y 2 son verdaderos y una vez hecho el resultado se hace el OR variable 3 es verdadera

        // La primera operacion de Variable 01 y 02 Da False por que la variable 2 es falsa pero como después se pregunta o Variable 3 verdadero y en este casi la variable 03 si es verdadera entonces dara un resultado de TRUE
        {
            Debug.Log("Operación línea 64 Verdadero");
        }

        else
        {
            Debug.Log("Operación Línea 64 Falso");
        }

        // else if statements

        if ((Variable01 && Variable02) && !Variable03) // si este da verdadero los otros dos no compilaran, si este es falso pasara al sig else if
        {
            Debug.Log("1st Verdadero");
        }
        else if ((!Variable01 || Variable02) && !Variable03) //// si este da verdadero el otro no compilaran, si este es falso pasara al sig else if
        {
            Debug.Log("2nd Verdadero");
        }

        else if ((Variable01 || Variable02) || Variable03) //si este es falso y hubiera otro else if pasaria el codigo a evaluar el siguiente else if
        {
            Debug.Log("Ding Ding Ding");
        }



        // ----------------------------------Switchers---------------------------------------------------

        Valor01 = Random.Range(LimiteInferior, LimiteSuperior);   //seleccionamos el valor 01 que ya existe y le damos un valor random range con los limites establecidos que ya creamos
        Debug.Log(Valor01); // una vez teniendo esos valores imprimimos el valor
        switch (Valor01)     // ahora que tenemos el valor empezamos con nuestra sentencia switch { }
        {
            case (int)SeleccionDeColor.rojo:  //los valores de colores que establecimos en los limites superiores o inferiores estan mapeados a valores enteros de 0 a 4
                Debug.Log("El Color seleccionado es Rojo");
                break; //break es para salirnos del switch
            case (int)SeleccionDeColor.verde:
                Debug.Log("El Color seleccionado es Verde");
                break;
            case (int)SeleccionDeColor.azul: // al enum (la lista de colores rojo, verde, etc) tiene valores enteros debemos poner (int) antes de seleccion de color para convertirlo en un valor entero a esto se le llama casteo
                Debug.Log("El Color seleccionado es Azul");
                break;
            case (int)SeleccionDeColor.blanco:
                Debug.Log("El Color seleccionado es Blanco");
                break;

            // agregamos when para agregar otra condicional si el enum da gris pero (en este caso) la variable01 no es verdadera entonces omitira esta línea y se ira a la siguiente que si sea verdade o falsa dependiendo del operado ( == > ! < <=) que hayamos puesto después de when
            case (int)SeleccionDeColor.gris when Variable01 == true:
                Debug.Log("El Color seleccionado es Gris");
                break;


            default: // default es por si el switch escoje uno valor que no definimos (de 5 para arriba)  esto si hacemos el limite superior a un número mayor de 4 (4 son los objetos que tenemos en el enum) si pasara de 5 a 10 ya nos daria el valor default
                Debug.Log("Este valor no existe");
                break;

                //         // esto nos ayuda a tener ciertos estados dentro de mi juego dependiendo en que parte estemos (menú, gameplay, etc)
                // }
                //      -------------------
                // Null conditioner operator "  ?   "
                // aqui en el string ponemos una variable (resultado) y esta preguntara si el Valor 01 es mayor o igual que 0
                // si es positivo dara  el primer resultado y si es negativo dara el segundo 
                // toma en cuenta que esto es por que en la línea de codigo de arriba pusimos que el  Valor01 es igual al valor Random.Range de los limites superiores o inferiores con esos limites establecidos ya nos da el número random en este caso de -5 a 5
                string resultado = (Valor01 >= 0) ? "El valor es positivo" : "el valor es negativo ";
                Debug.Log(resultado);






        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
