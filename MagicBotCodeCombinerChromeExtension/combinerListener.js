let listenerLocation = document.getElementById('listenerLocation');
//listenerLocation.textContent = 'hello there';
var listenerLocationPort;

var hitPlayInIDE = function() {
	window.document.dispatchEvent(new CustomEvent('ExternalEditorToIDE', {
      'detail': {'status': 'play'}
    }));
}

var updateCodeInIDE = function(code) {
	window.document.dispatchEvent(new CustomEvent('ExternalEditorToIDE', {
      'detail': {'status': 'updateCode', 'code': code.replace(/\r\n/g, '\n').replace(/\r/g, '\n')}
    }));
	setTimeout(hitPlayInIDE, 1000)
};

var launchListener =  function(){
	var listener = listenerLocationPort;

	function getCommand(){
		console.log("Waiting for code....");
		var postData = { 
			"action": "getCommand" 
		};

		$.post( listener, postData, function(response){
			updateCodeInIDE(response);
		});
	}

	setInterval(getCommand, 2000);
};

chrome.storage.sync.get('combinerLocation', function(data) {
	listenerLocationPort = data.combinerLocation;
    //listenerLocation.textContent = listenerLocationPort;

    launchListener();
});

