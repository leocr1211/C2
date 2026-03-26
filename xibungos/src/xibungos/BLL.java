package xibungos;

import minhabiblioteca.Erro;

public class BLL {

    public static void mostrandodados(Livrosclasse _novolivro) {
 
        Erro.setErro(false);
        
        if (_novolivro.getTitulo().trim().isEmpty()) {
            Erro.setErro("O campo 'Título' é obrigatório.");
            return;
        }
        if (_novolivro.getAutor().trim().isEmpty()) {
            Erro.setErro("O campo 'Autor' é obrigatório.");
            return;
        }
        if (!_novolivro.getAutor().matches("^[A-Za-zÀ-ÿ ]+$")) {
            Erro.setErro("O campo 'Autor' deve conter apenas letras.");
            return;
        }
        if (_novolivro.getEditor().trim().isEmpty()) {
            Erro.setErro("O campo 'Editora' é obrigatório.");
            return;
        }
        if (_novolivro.getAnoedicao().trim().isEmpty()) {
            Erro.setErro("O campo 'Ano de Edição' é obrigatório.");
            return;
        }
        if (!_novolivro.getAnoedicao().matches("\\d+")) {
            Erro.setErro("O 'Ano de Edição' deve conter apenas números.");
            return;
        }
        if (_novolivro.getAnoedicao().length() != 4) {
            Erro.setErro("O 'Ano de Edição' deve ter 4 dígitos (ex: 1998).");
            return;
        }
        if (_novolivro.getLocal().trim().isEmpty()) {
            Erro.setErro("O campo 'Local' é obrigatório.");
            return;
        }
    }
}