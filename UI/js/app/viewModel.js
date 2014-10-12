
   var serverUrl = "http://localhost:7041/"
	
	// Objeto JS Cliente
	function Cliente(id, nome, endereco, telefoneResidencial, telefoneCelular, dataNascimento) {
        return {
			Id: ko.observable(id),
			Nome: ko.observable(nome),
			Endereco: ko.observable(endereco),
			TelefoneReseidencial: ko.observable(telefoneResidencial),
			TelefoneCelular: ko.observable(telefoneCelular),
            DataNascimento: ko.observable(dataNascimento)
        }
    };

	
	var self = this;
    self.Clientes = ko.observableArray([]);

    carregarClientes();

    function carregarClientes() {
        $.ajax({
            type: "GET",
            url: serverUrl + "api/Clientes",
            success: function (data) {
                alert("Success");
                self.Clientes(data);
            },
            error: function (err) {
                alert(err.status + " <--------------->");
            }
        });

    };
    alert("Carregando...");
	var ClienteVM ={ exibeClienteTemplate : ko.observable("exibeClienteTemplate")};
	ko.applyBindings(ClienteVM);
