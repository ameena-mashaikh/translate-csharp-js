// Put your code here

//Need an array for all spells
//Good book and bad book objects with titles

const spells = [
    {
        name: "Turn enemy into a newt",
        isEvil: true
    },
    {
        name: "Conjure some gold for a local charity",
        isEvil: false
    },
    {
        name: "Give a deaf person the ability to heal",
        isEvil: false
    },
    {
        name: "Make yourself emperor of the universe",
        isEvil: true
    },
    {
        name: "Convince your relatives your political views are correct",
        isEvil: false
    }
]

const spellBooks = () => {
    let goodResponse = 'Good Book';
    let badResponse = '\nEvil Book'
    let allResp = ''
    spells.filter((spell) => {
        if (!spell.isEvil) {
            goodResponse += `\n \t${spell.name}`
        }
        else if (spell.isEvil) {
            badResponse += `\n \t${spell.name}`
        }
    })
    allResp = `${goodResponse}\n` + ` ${badResponse}`
    return allResp
}

console.log(spellBooks())