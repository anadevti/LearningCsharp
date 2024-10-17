### Compilação e interpretação

- Linguagens compiladas:
    - C, C++
        - Voce tem um compilador dedicado para cada sistema operacional

- Linguagens interpretadas:
    - Python, php, js
        - Voce tem um interpretador que roda em qualquer sistema operacional (é um processo
          mais lento que o compilado)

- pré compiladas + vm:
    - Java, C#
        - Voce compila o código para um bytecode que é interpretado por uma máquina virtual
          (passa por um proceso de pré-compilação,e gera o bytecode, ela é agnostica em relação
          ao sistema operacional, o byte é executado encima da máquina virtual de cada sistema operacional)
        - vantagem: portabilidade
        - desvantagem: performance

### Modelo de execução: (Passo a passo)
    - o programador escreve o código
    - o código é pré compilado (just in time)
    - Isso irá gerar um bytecode (Common intermediate language)
    - O bytecode é interpretado pela máquina virtual do SO em especifico


## Estrutra de uma app .Net

- é composta por classes
    - elas podem ser agrupadas em namespaces
        - Namespace: é um agrupamento de LÓGICO de classes relacionadas

    - Assembly (DLL ou EXE, basicamente é um build(executavel))
        - Agrupamento FISICO de classes relacionadas

    - Aplicação: é um agrupamento de assemblies relacionadas
        - Aplicação == Solution
        - Assembly == Project

### Estrutura de um projeto C# (solução)
    - Estrutura de arquivos:
        - Arquivo .sln: é o arquivo de solução
        - Arquivo .csproj: é o arquivo de projeto
        - Classe principal .cs: é o arquivo de código fonte
        - subpastas obj e bin: são pastas de compilação (arquivos compilados)

    - Program.cs
        - clausula using: referencia a outro namespace
        - Namespace: é um agrupamento de classes
        - Classe: é um agrupamento de métodos
        - Método: é um agrupamento de instruções
        - static void Main(string[] args): é o ponto de entrada da aplicação

### Placeholders, concatenação e interpolação
    - Placeholders: "{0} {1} {2}"
    - Concatenação: " " + " " + " "
    - Interpolação: $"{variavel} {variavel} {variavel}"