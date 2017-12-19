##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Visitor 

> Em programação orientada a objetos e engenharia de software, o visitor pattern é um padrão de projeto comportamental. Representa uma operação a ser realizada sobre elementos da estrutura de um objeto. O Visitor permite que se crie uma nova operação sem que se mude a classe dos elementos sobre as quais ela opera. É uma maneira de separar um algoritmo da estrutura de um objeto. Um resultado prático é a habilidade de adicionar novas funcionalidades a estruturas de um objeto pré-existente sem a necessidade de modificá-las.

> A ideia é usar uma classe de elementos como uma estrutura, sendo que cada uma delas possui um método cujo um dos argumentos é um objeto do tipo visitor. Visitor é uma interface que possui um método visit() para cada classe de elementos. O método accept() de uma classe de elementos invoca o método visit() de sua respectiva classe. Classes visitor concretas distintas podem então ser escritas para implementar operações especiais.

> O padrão Visitor é uma solução para separar o algoritmo da estrutura. Uma das vantagens desse padrão é a habilidade de adicionar novas operações a uma estrutura já existente. Com ele, podemos ter a classe ObjetoSolido e o comportamento de queda em uma classe Gravidade, separada da estrutura do ObjetoSolido. Isso é feito através de uma interface, onde o objeto que vai executar esse método da classe do comportamento, passa uma referencia dela mesmo junto dos parâmetros normais da classe. No caso desse exemplo, teríamos:


```java
Visitor gravidade = new Gravidade(); //esse é o nosso visitor, responsável pelo comportamento de queda.
Solido solido = new Solido("caixa"); //solido que recebera o comportamento
solido.accept(gravidade); //recebe o comportamento Gravidade
```

```java
public void accept(Visitor visitor) {
visitor.visitSolido(this);
}
```

> Ao passar para o Visitor uma referencia de si mesmo, o visitor pode acessar os métodos e atributos públicos dessa classe, que no nosso caso, vai adicionar a aceleração da gravidade ao Solido. Assim como o comportamento de queda foi adicionado, outros também poderiam ser feitos da mesma maneira, como movimentação através do teclado, sons... as possibilidades são infinitas.

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Visitor`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  