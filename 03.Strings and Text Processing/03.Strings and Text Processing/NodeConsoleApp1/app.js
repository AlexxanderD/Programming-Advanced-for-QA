function isValidMessage(input) {
    const regex = /([$%])([A-Z][a-z]+): \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|/;
    const match = input.match(regex);

    if (match && match[1] === match[6]) {
        const tag = match[2];
        const decryptMessage = String.fromCharCode(Number(match[3]), Number(match[4]), Number(match[5]));
        console.log(`${tag}: ${decryptMessage}`);
    } else {
        console.log("Valid message not found!");
    }
}

function processInputs(inputs) {
    const n = parseInt(inputs[0]);

    for (let i = 1; i <= n; i++) {
        isValidMessage(inputs[i]);
    }
}

// Example usage
const inputs = [
    '3',
    '$Request$: [73]|[115]|[32]|',
    '%Invalid$: [105]|[32]|[117]|',
    '$Another$: [72]|[101]|[108]|',
];

processInputs(inputs);
