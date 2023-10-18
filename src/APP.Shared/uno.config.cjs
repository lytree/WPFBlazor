import { defineConfig } from 'unocss'

export default defineConfig({
    cli: {
        entry: {
            patterns: ["./**/*.razor"],
            outFile: "./wwwroot/lib/uno.css"
        }, // CliEntryItem | CliEntryItem[]
    },
    // ...
})