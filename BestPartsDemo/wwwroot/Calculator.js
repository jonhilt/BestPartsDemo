export class Calculator {
    constructor(name, precision = 2) {
        this.name = name;
        this.precision = precision;
        this.history = [];
    }

    add(a, b) {
        const result = parseFloat((a + b).toFixed(this.precision));
        this.history.push(`${a} + ${b} = ${result}`);
        return result;
    }
    
    subtract(a, b) {
        const result = parseFloat((a - b).toFixed(this.precision));
        this.history.push(`${a} - ${b} = ${result}`);
        return result;
    }
    
    multiply(a, b) {
        const result = parseFloat((a * b).toFixed(this.precision));
        this.history.push(`${a} * ${b} = ${result}`);
        return result;
    }
    
    divide(a, b) {
        if (b === 0) {
            this.history.push(`Attempted to divide ${a} by zero`);
            throw new Error("Division by zero is not allowed.");
        }
        const result = parseFloat((a / b).toFixed(this.precision));
        this.history.push(`${a} / ${b} = ${result}`);
        return result;
    }

    get lastOperation() {
        return this.history[this.history.length - 1] || "No operations yet";
    }

    clear() {
        this.history = [];
    }
}