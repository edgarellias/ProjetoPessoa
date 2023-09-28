using ProjetoPessoa.models;
using ProjetoPessoa.view;

List<Pessoa> listaPessoas = new List<Pessoa>();

Pessoa p1 = new Pessoa("Edgar", 27, "10029539201");

listaPessoas.Add(p1);


Menu menu = new Menu();
menu.mostraMenu();
