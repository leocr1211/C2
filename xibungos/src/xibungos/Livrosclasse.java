package xibungos;

public class Livrosclasse {
    private String titulo;
    private String autor;
    private String editor;
    private String anoedicao;
    private String local;
    
    public void setTitulo(String _titulo) {titulo = _titulo;}
    public void setAutor(String _autor) {autor = _autor;}
    public void setEditor(String _editor) {editor = _editor;}
    public void setAnoedicao(String _anoedicao) {anoedicao = _anoedicao;}
    public void setLocal(String _local) {local = _local;}
    public String getTitulo() {return titulo;}
    public String getAutor() {return autor;}
    public String getEditor() {return editor;}
    public String getAnoedicao() {return anoedicao;}
    public String getLocal() {return local;}
}
