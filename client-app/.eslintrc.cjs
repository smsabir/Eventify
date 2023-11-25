module.exports = {
  root: true,
  env: {"browser": true,
  "es2021": true,
  "jest": true },
  extends: [
        "airbnb-typescript",
        "plugin:import/typescript"
  ],
  ignorePatterns: ['dist', '.eslintrc.cjs'],
  parser: '@typescript-eslint/parser',
  plugins: ['@typescript-eslint', 'react-refresh'],
  rules: {
    'react-refresh/only-export-components': [
      'warn',
      { allowConstantExport: true },
    ],
    "@typescript-eslint/no-explicit-any": "error"
  },
}
