Module Module1

    Sub Main()
        'Realizar un programa que calcule el número Tarot de una persona. 
        'El programa debe estar solicitar al usuario su fecha de nacimiento y en función de esta fecha, realizar el cálculo correspondiente.
        'Una vez mostrado un número Tarot, se solicitará la siguiente fecha hasta que el usuario teclee la fecha '1/1/1, caso con en el que debe finalizar el programa.

        Dim fechanac As Date
        Dim fechanacInt As Integer
        Dim fechanacStr, respuesta As String
        Dim sw As Boolean

        Do
            Console.Write("Introduce la fecha en formato (dia/mes/año): ")
            fechanac = Console.ReadLine()

            fechanacStr = CStr(fechanac)

            If fechanacStr <> "01/01/2001" Then     'Sumo las cifras equivalentes a dia / mes / año por separado

                fechanacInt = CInt(fechanacStr.Substring(0, 2))
                fechanacInt = CInt(fechanacStr.Substring(3, 2)) + fechanacInt
                fechanacInt = CInt(fechanacStr.Substring(6, 4)) + fechanacInt

                fechanacStr = CInt(fechanacInt)     'Hago la conversion de dicha suma a String

                fechanacInt = 0

                For contador = 0 To 3               'Sumo el restante de las cifras

                    fechanacInt = CInt(fechanacStr.Substring(contador, 1)) + fechanacInt

                Next

                fechanacStr = fechanacInt


                If fechanacInt > 9 Then           'Si es mayor o igual a 10 vuelvo a sumar dichas cifras
                    fechanacInt = 0
                    For contador = 0 To 1


                        fechanacInt = CInt(fechanacStr.Substring(contador, 1)) + fechanacInt

                        ' Anotaciones Jon
                        ' while suma > 9'
                        ' variable = suma \ 10
                        ' resto = suma Mod 10
                        ' suma = variable + resto

                    Next

                End If

                Console.WriteLine("Tu tarot es: " & fechanacInt)

                Do
                    Console.Write("Desea continuar(Si/No): ")
                    respuesta = Console.ReadLine.ToLower()

                    If respuesta = "si" Then
                        sw = True
                    ElseIf respuesta = "no" Then
                        sw = False
                        Console.WriteLine("Fin del programa")
                    Else
                        Console.Write("Has introducido una respuesta no valida")
                    End If

                Loop While respuesta <> "si" And respuesta <> "no"

            Else
                Console.WriteLine("Has introducido 1/1/1, fin del programa")
                sw = False
            End If
        Loop While sw = True
          

        Console.ReadLine()


    End Sub

End Module
