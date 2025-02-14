import random
import time
import os

width = 20
height = 20

class Map:
    def __init__(self, width, height):
        self.width = width
        self.height = height
        self.map = [['.' for _ in range(width)] for _ in range(height)]
        self.animals = []

    def add_point(self, x, y, symbol='E'):
        if 0 <= x < self.width and 0 <= y < self.height:
            self.map[y][x] = symbol

    def delete_point(self, x, y):
        self.map[y][x] = "."

    def is_symbol_at(self, x, y, target_symbol):
        if 0 <= x < self.width and 0 <= y < self.height:
            return self.map[y][x] == target_symbol
        return False

    def get_characters_around(self, x, y, radius=1):
        characters_around = []

        for i in range(max(0, x - radius), min(self.width, x + radius + 1)):
            for j in range(max(0, y - radius), min(self.height, y + radius + 1)):
                if not (i == x and j == y):  # Exclude the center coordinate
                    character = self.map[j][i]
                    coordinates = [i, j]
                    characters_around.append((character, coordinates))

        return characters_around

    def move_point(self, oldx, oldy, newx, newy, animal):
        self.map[oldy][oldx] = "."
        self.map[newy][newx] = animal.type
        animal.x = newx
        animal.y = newy

    def add_animal(self, animal):
        self.animals.append(animal)
        self.map[animal.y][animal.x] = animal.type

    def remove_animal(self, animal):
        if animal in self.animals:
            self.animals.remove(animal)
            self.map[animal.y][animal.x] = "."

    def display_map(self):
        # Térkép újraépítése
        self.map = [['.' for _ in range(self.width)] for _ in range(self.height)]
        for animal in self.animals:
            self.map[animal.y][animal.x] = animal.type

        # Térkép kijelzése
        for row in self.map:
            print(' '.join(row))


class Animal:
    def __init__(self, type, x, y, map_instance):
        self.x = x
        self.y = y
        self.type = type
        self.ehseg = 0
        self.eletkor = 0
        self.map = map_instance
        if type == "R":
            self.maxelet = random.randint(9, 12)
        elif type == "N":
            self.maxelet = random.randint(11, 14)

        map_instance.add_animal(self)

    def evmulas(self):
        self.eletkor += 1
        if self.type == "N":
            print(self.eletkor)
        if self.eletkor >= self.maxelet:
            self.meghal()

    def meghal(self):
        self.map.remove_animal(self)

    def eves(self, status):
        if status == 1:
            self.ehseg = 0
        else:
            self.ehseg += 1

        if self.ehseg >= 2:
            self.meghal()


def allat_generalas(char_map):
    count_novenyevo = 0
    count_ragadozo = 0
    while count_novenyevo + count_ragadozo != 180:
        x = random.randint(0, char_map.height - 1)
        y = random.randint(0, char_map.width - 1)

        # Mindkét esélyt lekérdezzük
        esely_novenyevo = random.random()
        esely_ragadozo = random.random()

        if not char_map.is_symbol_at(x, y, 'R') and not char_map.is_symbol_at(x, y, 'N'):
            # 65% eséllyel növényevő
            if esely_novenyevo < 0.65:
                char_map.add_point(x, y, 'N')
                Animal("N", x, y, char_map)
                count_novenyevo += 1

            # 35% eséllyel ragadozó
            elif esely_ragadozo < 0.35:
                Animal("R", x, y, char_map)
                count_ragadozo += 1


def szimulacio(cel, char_map):
    for ev in range(1, cel + 1):
        for animal in char_map.animals:
            animal.evmulas()

            if animal.type == "R":
                animals_around = char_map.get_characters_around(animal.x, animal.y)
                n_index = [index for index, (karakter, _) in enumerate(animals_around) if karakter == 'N']
                if n_index:
                    random_n_index = random.choice(n_index)
                    for other_animal in char_map.animals:
                        if other_animal.x == animals_around[random_n_index][1][0] and other_animal.y == animals_around[random_n_index][1][1]:
                            other_animal.meghal()
                else:
                    animal.eves(0)

            animals_around_eves_utan = char_map.get_characters_around(animal.x, animal.y)
            terulet_index = [index for index, (karakter, _) in enumerate(animals_around_eves_utan) if karakter == '.']

            if terulet_index:
                random_terulet = random.choice(terulet_index)
                char_map.move_point(animal.x, animal.y, animals_around_eves_utan[random_terulet][1][0],
                                    animals_around_eves_utan[random_terulet][1][1], animal)

        char_map.display_map()
        print(f"{ev}. év")
        time.sleep(2)


if __name__ == "__main__":
    cel = 100
    map = Map(width, height)
    allat_generalas(map)
    map.display_map()
    print("0. év")
    szimulacio(cel, map)
