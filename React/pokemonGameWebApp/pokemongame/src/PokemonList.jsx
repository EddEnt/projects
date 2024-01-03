import React from 'react'

export default function PokemonList({ pokemon }) {

    return (
        <div>
            {pokemon.map(pokies => (
                <div key={pokies}>{ pokies }</div>
            ))}
        </div>
    )
}