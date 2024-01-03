import React, { useState } from 'react';

function App() {
    const [text, setText] = useState('');

    const handlePaste = (event) => {
        setText(event.target.value);
    };

    return (
        <div>
            <h1>Paste your text here:</h1>
            <textarea 
                value={text}
                onChange={handlePaste}
                placeholder="Paste your text here"
                rows="10" 
                cols="50"
            />
            <p>You pasted: {text}</p>
        </div>
    );
}

export default App;
