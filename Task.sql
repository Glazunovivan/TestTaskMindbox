﻿//SQL запрос для выбора всех пар "Имя продукта - Имя категории"

SELECT "имяПродукта", "названиеКатегории" 
FROM "Таблица с продуктами" 
LEFT JOIN "Таблица с категориями и продуктами" 
	ON idПродукта = idПродуктаИзСводнойТаблицы(в которой хранятся и продукты и категории)
LEFT JOIN "Таблица с категориям"
	ON "Таблица с категориями и продуктами".IDКатегории = "Таблица с категориями".Id